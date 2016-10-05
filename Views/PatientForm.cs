using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Shakespeare.Forms.Controllers;
using Shakespeare.Forms.Models;

namespace Shakespeare.Forms.Views
{
    public partial class PatientForm : Form
    {
        private readonly PatientController controller;
        private Patient selectedPatient;

        public PatientForm(PatientController controller)
        {
            if (controller == null)
            {
                throw new ArgumentNullException("controller");
            }

            this.controller = controller;

            // Sætter font til Segoe UI (Windows 7 font.)
            Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            ActiveControl = cprMaskedTextBox;
        }

        public Patient SelectedPatient
        {
            get { return this.selectedPatient; }
            set
            {
                this.selectedPatient = value;

                if (SelectedPatient != null)
                {
                    cprMaskedTextBox.Text = selectedPatient.Cpr;
                    fornavnTextBox.Text = selectedPatient.Fornavn;
                    efternavnTextBox.Text = selectedPatient.Efternavn;
                    adresseTextBox.Text = selectedPatient.Adresse;
                    postnrMaskedTextBox.Text = selectedPatient.Postnr;
                    byTextBox.Text = selectedPatient.By;
                    tlfMaskedTextBox.Text = selectedPatient.Tlf;
                    okButton.Enabled = true;
                }
                else
                {
                    cprMaskedTextBox.Text = null;
                    fornavnTextBox.Text = null;
                    efternavnTextBox.Text = null;
                    adresseTextBox.Text = null;
                    postnrMaskedTextBox.Text = null;
                    byTextBox.Text = null;
                    tlfMaskedTextBox.Text = null;
                    okButton.Enabled = false;
                }
            }
        }

        private void findPatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedPatient = this.controller.HentPatient(cprMaskedTextBox.Text.Remove(6, 1));
                okButton.Focus();      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Shakespeare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CprMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            string cpr = cprMaskedTextBox.Text ?? string.Empty;

            if (this.controller.ErGyldigCpr(cpr))
            {
                findPatientButton.Enabled = true;
            }
            else
            {
                findPatientButton.Enabled = false;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.controller.GemPatient(SelectedPatient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Shakespeare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void annullerButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void PatientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Cancel)
            {
                SelectedPatient = null;
            }
        }

        private void cprMaskedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                findPatientButton.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}