using System.Transactions;
using Shakespeare.Forms.Controllers;
using Shakespeare.Forms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Misc;

namespace Shakespeare.Forms.Views
{
    public partial class BehandlingForm : Form
    {
        private readonly OpretBehandlingController controller;
        private readonly BindingList<Personale> personale; 
        private readonly BindingList<Personale> tilknyttetPersonale;
        private readonly BindingList<LokaleMedTid> lokaler;
        private int selectedRow = -1;
        private bool skipOphold;

        public BehandlingForm(OpretBehandlingController controller, bool skipOphold)
        {
            this.controller = controller;
            this.skipOphold = skipOphold;

            // Sætter font til Segoe UI (Windows 7 font.)
            Font = SystemFonts.MessageBoxFont;
            InitializeComponent();

            if (skipOphold)
            {
                this.Wizard.Pages.Single(p => p.Text == "Registrer ophold").Enabled = false;
            }

            this.personale = new BindingList<Personale>(this.controller.HentPersonale());            
            this.personaleListBox.DataSource = this.personale;

            this.tilknyttetPersonale = new BindingList<Personale>();
            this.tilknyttetPersonale.ListChanged += TilknyttetPersonaleOnListChanged;
            this.tilknyttetPersonaleListBox.DataSource = this.tilknyttetPersonale;

            this.lokaler = new BindingList<LokaleMedTid>();
            this.Wizard.NextCommand = new RelayCommand(_ => this.Wizard.NextPage(), CanNext);

            // Vælg operationsradiobutton, så der bliver indlæst data fra starten.
            this.operationRadioButton.Checked = true;

            // Hent alle specialer og tilføj et tomt felt til "Alle".
            IList<Speciale> specialer = this.controller.HentSpecialer();
            specialer.Insert(0, new Speciale(-1, "Alle"));
            this.specialeComboBox.DataSource = specialer;

            // Sæt "vælg behandlingsdato"-picker til minimum dato opholdets startdato,
            // og sæt max. dato til opholdets slutdato. Sæt således den valgte dato
            // til opholdets start dato.
            this.behandlingsdatoPicker.Value = DateTime.Today;

            // Hent "advarselsikon" fra SystemIcons og lav det om til et Image object, da
            // SystemIcons.Warning normalt er et Icon object.
            Bitmap warningIcon = SystemIcons.Warning.ToBitmap();
            this.vælgBehandlingIconLabel.Icon = warningIcon;
            this.tilknytPersonaleIconLabel.Icon = warningIcon;
            this.arbejdsdageIconLabel.Icon = warningIcon;
            this.findLokaleIconLabel.Icon = warningIcon;            

            // Opdater "Kan vi gå videre"-forbindelsen.
            this.Wizard.NextCommand.RaiseCanExecuteChanged();

            enkeltRadioButton.Checked = true;

            // Fyld forplejningscombobox op med forplejninger.
            this.forplejningerComboBox.DataSource = this.controller.HentForplejninger();
        }

        public Ophold SelectedOphold { get; set; }

        #region Valg af behandling

        private void operationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.behandlingDataGridView.DataSource = this.controller.HentOperationer();
        }

        private void genoptræningRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.behandlingDataGridView.DataSource = this.controller.HentGenoptræninger();
        }

        private void behandlingDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            this.vælgBehandlingIconLabel.Visible = this.behandlingDataGridView.SelectedRows.Count == 0;
            this.Wizard.NextCommand.RaiseCanExecuteChanged();
        }

        private Behandling HentBehandling()
        {
            // Behandling er den valgte rækkes "data bound item", dvs. det item der lægger bag de data, der vises ("Data source.")
            return (Behandling) this.behandlingDataGridView.SelectedRows[0].DataBoundItem;
        }

        #endregion

        #region Valg af lokale

        private void behandlingsdatoPicker_ValueChanged(object sender, EventArgs e)
        {
            this.lokaleDataGridView.ClearSelection();
            this.lokaleDataGridView.Rows.Clear();
            this.lokaler.Clear();

            // Hent behandlingslinjer.
            DateTime behandlingsdato = behandlingsdatoPicker.Value;
            var lokalerMedTid = this.controller.HentLokalerMedTid(behandlingsdato);

            foreach (LokaleMedTid lokale in lokalerMedTid)
            {
                this.lokaler.Add(lokale);
                var row = new DataGridViewRow { HeaderCell = { Value = lokale.Lokale.Navn } };
                this.lokaleDataGridView.Rows.Add(row);

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    DataGridViewCell cell = row.Cells[i];

                    if (lokale[i])
                    {
                        cell.Style.BackColor = Color.Blue;
                    }
                }
            }

            slutdatoDateTimePicker.MinDate = behandlingsdato.AddDays(1);
            startdatoDateTimePicker.MaxDate = behandlingsdato;
            startdatoDateTimePicker.Value = behandlingsdato;
        }

        private void lokaleDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.lokaleDataGridView.SelectedCells.Count > 0)
            {
                this.selectedRow = this.lokaleDataGridView.SelectedCells[this.lokaleDataGridView.SelectedCells.Count - 1].RowIndex;
            }
            else
            {
                this.selectedRow = -1;
            }

            for (int i = 0; i < this.lokaleDataGridView.SelectedCells.Count; i++)
            {
                DataGridViewCell celle = this.lokaleDataGridView.SelectedCells[i];

                // "De-select" de valgte celler, der ligger uden for rækken.
                if (celle.RowIndex != this.selectedRow)
                {
                    celle.Selected = false;
                }
                // Man må heller ikke vælge celler, der er optagede.
                else if (this.lokaler[celle.RowIndex][celle.ColumnIndex])
                {
                    celle.Selected = false;
                }
            }

            // Vi skal også lige teste, at alle cellerne er kontinuerte (dvs. man må ikke 
            // CTRL + klikke på enkelte felter.)
            if (this.lokaleDataGridView.SelectedCells.Count > 0)
            {
                int start = this.lokaleDataGridView.SelectedCells[0].ColumnIndex;

                for (int i = 0; i < this.lokaleDataGridView.SelectedCells.Count; i++)
                {
                    DataGridViewCell celle = this.lokaleDataGridView.SelectedCells[i];

                    if (Math.Abs(celle.ColumnIndex - start) > 1)
                    {
                        celle.Selected = false;
                    }

                    start = celle.ColumnIndex;
                }
            }

            this.findLokaleIconLabel.Visible = !CanNext(null);
            this.Wizard.NextCommand.RaiseCanExecuteChanged();
        }

        private Lokale HentLokale()
        {
            return this.lokaler[this.selectedRow].Lokale;
        }

        private DateTime HentStarttidspunkt()
        {
            // Dato er behandlingsdatoPicker'ens værdi.
            DateTime dato = this.behandlingsdatoPicker.Value;

            // Det lader til, at de valgte celler gemmes i en form for linked list (men stadig med []), hvor de nyest valgte gemmes først.
            // Derfor er er starttidspunkt den sidste i listen - og vi har 24 kolonner, så tidspunktet er det samme som dets indeks (indeks 0: kl. 00.00.)
            int startTidspunkt = this.lokaleDataGridView.SelectedCells[this.lokaleDataGridView.SelectedCells.Count - 1].ColumnIndex;
            return dato.AddHours(startTidspunkt);
        }

        private DateTime HentSluttidspunkt()
        {
            // Dato er behandlingsdatoPicker'ens værdi.
            DateTime dato = this.behandlingsdatoPicker.Value;

            // Sluttidspunkt er derfor den første i listen.
            int slutTidspunkt = this.lokaleDataGridView.SelectedCells[0].ColumnIndex;
            return dato.AddHours(slutTidspunkt);
        }

        #endregion

        #region Tilknytning af personale

        private void specialeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var speciale = (Speciale) this.specialeComboBox.SelectedItem;
            var specialister = this.personale.ToList();

            if (speciale.Id >= 0)
            {
                // Filtrer efter speciale.
                specialister = specialister.Where(p => p.Speciale.Id == speciale.Id).ToList();
            }

            this.personaleListBox.DataSource = specialister;
        }

        private void personaleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tilknytButton.Enabled = this.personaleListBox.SelectedIndices.Count > 0;
        }

        private void TilknyttetPersonaleOnListChanged(object sender, ListChangedEventArgs listChangedEventArgs)
        {
            this.tilknytPersonaleIconLabel.Visible = this.tilknyttetPersonale.Count == 0;
            DateTime behandlingsdato = this.behandlingsdatoPicker.Value;

            // Få fat på al det personale, der ikke kan arbejde i opholdets tidsrum.
            var doventPersonale = this.controller.PersonaleDerIkkeKanArbejdeITidsrum(behandlingsdato, this.tilknyttetPersonale);
            var joined = string.Join(", ", doventPersonale.Select(p => string.Format("{0} {1}", p.Fornavn, p.Efternavn)));
            this.arbejdsdageIconLabel.Text = string.Format("Følgende personale kan ikke arbejde d. {0}: {1}",
                                                           behandlingsdato.ToShortDateString(),
                                                           joined);
            this.arbejdsdageIconLabel.Visible = doventPersonale.Count > 0;
        }

        private void tilknyttetPersonaleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.fjernButton.Enabled = this.tilknyttetPersonaleListBox.SelectedIndices.Count > 0;
        }

        private void tilknytButton_Click(object sender, EventArgs e)
        {
            // Hent det valgte personale.
            IEnumerable<Personale> valgtPersonale = this.personaleListBox.SelectedItems.Cast<Personale>();

            // Tag kun dem, der ikke allerede er tilknyttet.
            IEnumerable<Personale> nytPersonale = valgtPersonale.Except(this.tilknyttetPersonale);

            foreach (Personale person in nytPersonale)
            {
                this.tilknyttetPersonale.Add(person);
            }

            this.personaleListBox.ClearSelected();            
            this.Wizard.NextCommand.RaiseCanExecuteChanged();
        }

        private void fjernButton_Click(object sender, EventArgs e)
        {
            // Hent det valgte personale.
            List<Personale> valgtPersonale = this.tilknyttetPersonaleListBox.SelectedItems.Cast<Personale>().ToList();

            foreach (Personale person in valgtPersonale)
            {
                this.tilknyttetPersonale.Remove(person);
            }

            this.tilknyttetPersonaleListBox.ClearSelected();
            this.Wizard.NextCommand.RaiseCanExecuteChanged();
        }

        #endregion

        #region Opret ophold

        private void FindSenge(object sender, EventArgs e)
        {
            int antalSenge = 0;

            if (enkeltRadioButton.Checked)
            {
                antalSenge = 1;
            }
            else if (dobbeltRadioButton.Checked)
            {
                antalSenge = 2;
            }

            this.værelseDataGridView.DataSource = controller.HentLedigeVærelser(startdatoDateTimePicker.Value, slutdatoDateTimePicker.Value, antalSenge);
        }

        private void slutdatoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (slutdatoDateTimePicker.Value < startdatoDateTimePicker.Value)
            {
                startdatoDateTimePicker.Value = slutdatoDateTimePicker.Value.AddDays(-1);
            }

            FindSenge(sender, e);
        }

        private void værelseDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Wizard.NextCommand.RaiseCanExecuteChanged();
        }

        #endregion

        private void Wizard_Next(object sender, CancelEventArgs e)
        {
            if (CanNext(null) == false)
            {
                e.Cancel = true;
            }

            // Den kommende side er oversigt - så vi fylder den lige ud med tekst.
            if (this.Wizard.SelectedIndex + 1 == 3)
            {
                FyldOversigtTextBox();
            }
        }

        private void Wizard_Previous(object sender, EventArgs e)
        {
        }

        private void FyldOversigtTextBox()
        {
            this.oversigtTextBox.Clear();

            this.oversigtTextBox.AppendText("Behandlingen bliver registreret med følgende indstillinger:");
            this.oversigtTextBox.AppendText(Environment.NewLine);
            this.oversigtTextBox.AppendText(Environment.NewLine);

            // Patient.
            this.oversigtTextBox.AppendText(string.Format("Patientens CPR-nr. er \"{0}\".", this.controller.Patient.Cpr));
            this.oversigtTextBox.AppendText(Environment.NewLine);
            this.oversigtTextBox.AppendText(Environment.NewLine);

            // Behandling.
            Behandling behandling = HentBehandling();
            this.oversigtTextBox.AppendText(string.Format("Den valgte behandling er \"{0}\" (ID {1}), der koster {2}.", behandling.Navn, behandling.Id.ToString(), behandling.Pris.ToString("C2")));
            this.oversigtTextBox.AppendText(Environment.NewLine);
            this.oversigtTextBox.AppendText(Environment.NewLine);

            // Tilknyttet personale.
            IList<Personale> personale = this.tilknyttetPersonale;
            this.oversigtTextBox.AppendText("Der er tilknyttet følgende personale til behandlingen:");
            this.oversigtTextBox.AppendText(Environment.NewLine);

            foreach (var person in personale)
            {
                this.oversigtTextBox.AppendText(string.Format("\t{0} {1}", person.Fornavn, person.Efternavn));
                this.oversigtTextBox.AppendText(Environment.NewLine);
            }

            this.oversigtTextBox.AppendText(Environment.NewLine);

            // Lokale.
            Lokale lokale = HentLokale();
            this.oversigtTextBox.AppendText(string.Format("Behandlingen vil foregå i lokalet \"{0}\" (ID {1}.)", lokale.Navn, lokale.Id.ToString()));
            this.oversigtTextBox.AppendText(Environment.NewLine);
            this.oversigtTextBox.AppendText(Environment.NewLine);

            // Dato/tid.
            DateTime dato = this.behandlingsdatoPicker.Value;
            DateTime start = HentStarttidspunkt();
            DateTime slut = HentSluttidspunkt();
            this.oversigtTextBox.AppendText(string.Format("Det foregår i tidsrummet {0}-{1} d. {2}.", start.ToShortTimeString(), slut.ToShortTimeString(), dato.ToShortDateString()));
        }

        private bool CanNext(object parameter)
        {
            // Her besluttes om brugeren kan få lov til at gå videre fra de enkelte sider.
            // Brug SelectedIndex til at finde ud af hvilken side vi er på (ikke hvilken side vi kommer til!)            
            switch (this.Wizard.SelectedIndex)
            {
                case 0:
                    // Der skal vælges en behandling.
                    return this.behandlingDataGridView.SelectedRows.Count != 0;
                case 1:
                    // Der skal vælges en start- og sluttid.
                    return this.lokaleDataGridView.SelectedCells.Count != 0;
                case 2:
                    // Der skal være tilknyttet mindst en person.
                    return this.tilknyttetPersonale.Count != 0;
                case 3:
                    return værelseDataGridView.SelectedRows.Count > 0;
                case 4:
                    // Next må ikke være slået til på oversigtssiden, da det er der, hvor Færdig-knappen virker.
                    return false;
                default:                    
                    return true;
            }
        }

        private void Wizard_Finishing(object sender, CancelEventArgs e)
        {
            // Behandling er den valgte rækkes "data bound item", dvs. det item der lægger bag de data, der vises ("Data source.")
            var forplejning = this.forplejningerComboBox.SelectedItem as Forplejning;

            using (var transactionScope = new TransactionScope())
            {
                try
                {
                    if (skipOphold == false)
                    {
                        var værelse = this.værelseDataGridView.SelectedRows[0].DataBoundItem as Værelse;

                        SelectedOphold = controller.OpretOphold(this.startdatoDateTimePicker.Value,
                            this.slutdatoDateTimePicker.Value, forplejning, værelse);
                    }

                    var behandling = HentBehandling();
                    Lokale lokale = HentLokale();
                    DateTime start = HentStarttidspunkt();
                    DateTime slut = HentSluttidspunkt();
                    this.controller.GemBehandling(SelectedOphold, behandling, lokale, start, slut, this.tilknyttetPersonale);
                    transactionScope.Complete();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Shakespeare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BehandlingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Vi skal ikke vise "Er du sikker blah blah," hvis vi ikke har trykket Annuller/kryds.
            if (DialogResult == DialogResult.OK)
            {
                return;
            }

            DialogResult result =
                MessageBox.Show("Er du sikker på, at du vil afslutte oprettelsen af behandlingen uden at gemme?",
                    "Shakespeare", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            e.Cancel = result == DialogResult.No;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.tilknyttetPersonale.ListChanged -= TilknyttetPersonaleOnListChanged;
            }

            base.Dispose(disposing);
        }
    }
}