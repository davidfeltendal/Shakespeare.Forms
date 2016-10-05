using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Shakespeare.Forms.Controllers;
using Shakespeare.Forms.Models;

namespace Shakespeare.Forms.Views
{
    public partial class PersonaleoplysningerForm : Form
    {
        private readonly PersonaleoplysningerController controller;
        private readonly IList<Speciale> specialer;

        public PersonaleoplysningerForm(PersonaleoplysningerController controller)
        {
            if (controller == null)
            {
                throw new ArgumentNullException("controller");
            }

            this.controller = controller;

            // Sætter font til Segoe UI (Windows 7 font.)
            Font = SystemFonts.MessageBoxFont;
            InitializeComponent();

            this.dataGridView.AutoGenerateColumns = false;
            this.specialer = this.controller.HentSpecialer();
            this.specialer.Insert(0, new Speciale(-1, string.Empty));
            this.comboBox.DataSource = this.specialer;
            this.comboBox.SelectedIndex = 0;
        }

        private void lukButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Speciale speciale = this.specialer[this.comboBox.SelectedIndex];
            this.listBox.DataSource = this.controller.HentPersonale(speciale);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var person = this.listBox.SelectedItem as Personale;

            if (person != null)
            {
                this.dataGridView.DataSource = this.controller.HentBehandlingslinjerForPerson(person);
                this.gemButton.Enabled = true;
            }
            else
            {
                this.dataGridView.DataSource = null;
                this.gemButton.Enabled = false;
            }
        }

        private void gemButton_Click(object sender, EventArgs e)
        {
            var person = (Personale) this.listBox.SelectedItem;

            using (var sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                sfd.FileName = string.Format("{1}_{0}_{2}", person.Fornavn, person.Efternavn, DateTime.Now.ToFileTimeUtc());
                sfd.DefaultExt = ".xml";
                sfd.AddExtension = true;
                sfd.Filter = "XML Files (*.xml)|*.xml";
                DialogResult result = sfd.ShowDialog();

                if (result != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    using (Stream stream = sfd.OpenFile())
                    {
                        stream.Position = 0;
                        this.controller.GemPersonaleoplysninger(person, stream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Shakespeare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
        }
    }
}
