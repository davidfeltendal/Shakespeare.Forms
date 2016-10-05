using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PdfSharp.Pdf;
using Shakespeare.Forms.Controllers;
using Shakespeare.Forms.Models;

namespace Shakespeare.Forms.Views
{
    public partial class FakturaForm : Form
    {
        private readonly IViewFactory viewFactory;
        private readonly FakturaController controller;
        private readonly BindingList<Fakturalinje> fakturalinjer; 

        private Patient patient;
        private Ophold ophold;

        public FakturaForm(IViewFactory viewFactory, FakturaController controller)
        {
            if (viewFactory == null)
            {
                throw new ArgumentNullException("viewFactory");
            }

            if (controller == null)
            {
                throw new ArgumentNullException("controller");
            }

            this.viewFactory = viewFactory;
            this.controller = controller;
            this.fakturalinjer = new BindingList<Fakturalinje>();
            this.fakturalinjer.ListChanged += FakturalinjerOnListChanged;

            // Sætter font til Segoe UI (Windows 7 font.)
            Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            this.fakturalinjerDataGridView.AutoGenerateColumns = false;
            this.fakturalinjerDataGridView.DataSource = this.fakturalinjer;
            this.fakturalinjer.ResetBindings();
        }

        public Ophold Ophold
        {
            get { return this.ophold; }
            private set
            {
                this.ophold = value;
                this.fakturalinjer.Clear();

                if (this.ophold != null)
                {
                    this.gemFakturaButton1.Enabled = true;
                    this.annullerButton.Enabled = true;

                    // Tilføj forplejning til faktura-preview
                    this.fakturalinjer.Add(
                        new Fakturalinje(
                            Ophold.Forplejning.Id,
                            Ophold.Forplejning.Navn,
                            Ophold.Forplejning.Pris,
                            ophold.AntalTimer / 24));

                    // Tilføj værelse til faktura-preview.
                    this.fakturalinjer.Add(
                        new Fakturalinje(
                            Ophold.Værelse.Id,
                            Ophold.Værelse.Navn,
                            Ophold.Værelse.Pris,
                            Ophold.AntalTimer / 24));

                    // Tilføj behandlingslinjer til preview.
                    foreach (var behandlingslinje in this.controller.HentBehandlingslinjerForOphold(Ophold))
                    {
                        this.fakturalinjer.Add(
                            new Fakturalinje(
                                behandlingslinje.Behandling.Id,
                                behandlingslinje.Behandling.Navn,
                                behandlingslinje.Behandling.Pris,
                                behandlingslinje.Antal));
                    }
                }
                else
                {
                    this.gemFakturaButton1.Enabled = false;
                    this.annullerButton.Enabled = false;
                }
            }
        }

        private void FakturalinjerOnListChanged(object sender, ListChangedEventArgs listChangedEventArgs)
        {
            decimal subtotal = this.fakturalinjer.Sum(fl => fl.Subtotal);
            decimal moms = subtotal * 0.25m;
            decimal total = subtotal + moms;
            this.subtotalLabel.Text = subtotal.ToString("C2");
            this.momsLabel.Text = moms.ToString("C2");
            this.totalLabel.Text = total.ToString("C2");
        }

        private void gemFakturaButton_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.AddExtension = true;
                sfd.DefaultExt = ".pdf";
                sfd.FileName = string.Format("{0}_{1}.pdf", this.patient.Cpr, DateTime.Now.ToFileTimeUtc());
                sfd.Filter = "PDF Documents (*.pdf)|*.pdf";
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                DialogResult result = sfd.ShowDialog();

                if (result != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    using (PdfDocument faktura = this.controller.GenererPdfDokument(this.patient, this.ophold))
                    using (Stream stream = sfd.OpenFile())
                    {
                        stream.Position = 0;
                        this.controller.GemFaktura(faktura, stream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Shakespeare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Process.Start(sfd.FileName);
            }
        }

        private void findPatientStripLabel_Click(object sender, EventArgs e)
        {
            using (var form = this.viewFactory.SkabPatientForm())
            {
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.patient = form.SelectedPatient;
                    this.cprLabel.Text = form.SelectedPatient.Cpr;
                    this.patientNavnLabel.Text = form.SelectedPatient.Fornavn + " " + form.SelectedPatient.Efternavn;
                    this.adresseLabel.Text = form.SelectedPatient.Adresse;
                    this.postByLabel.Text = form.SelectedPatient.Postnr + " " + form.SelectedPatient.By;
                    this.tlfLabel.Text = form.SelectedPatient.Tlf;
                    this.opretBehandlingStripLabel.Enabled = true;
                    this.visJournalStripLabel.Enabled = true;
                    this.findTidligereOpholdStripLabel.Enabled = true;
                    Ophold = null;
                }
            }
        }

        private void opretBehandlingStripLabel_Click(object sender, EventArgs e)
        {
            var result = DialogResult.No;

            if (Ophold != null)
            {
                result = MessageBox.Show("Ønsker du at registrere en ny behandling til samme ophold?", "Shakespeare",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            BehandlingForm form = null;

            try
            {
                form = result == DialogResult.No
                    ? this.viewFactory.SkabBehandlingForm(this.patient)
                    : this.viewFactory.SkabBehandlingForm(this.patient, this.ophold);

                result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Ophold = form.SelectedOphold;                    
                }
            }
            finally
            {
                if (form != null)
                {
                    form.Dispose();
                }
            }
        }

        private void visJournalStripLabel_Click(object sender, EventArgs e)
        {
            using (var form = this.viewFactory.SkabJournalForm(this.patient))
            {
                form.ShowDialog();
            }
        }

        private void findTidligereOpholdStripLabel_Click(object sender, EventArgs e)
        {
            using (var form = this.viewFactory.SkabIndlæsFakturaForm(this.patient))
            {
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Ophold = form.SelectedOphold;
                }
            }
        }

        private void personaleoplysingerStripLabel1_Click(object sender, EventArgs e)
        {
            using (var form = this.viewFactory.SkabPersonaleoplysningerForm())
            {
                form.ShowDialog();
            }
        }

        private void annullerButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Er du sikker på du vil slette opholdet?",
                "Shakespeare",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                //Slet ophold på dgw(fakturapreview)
                controller.SletOphold(ophold);
                Ophold = null;
            }
        }
    }
}