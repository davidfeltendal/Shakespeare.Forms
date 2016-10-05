using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Shakespeare.Forms.Models;

namespace Shakespeare.Forms.Views
{
    public partial class FindTidligereOpholdForm : Form
    {
        private Ophold selectedOphold;

        public FindTidligereOpholdForm(IList<Ophold> ophold)
        {
            // Sætter font til Segoe UI (Windows 7 font.)
            Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            this.opholdDataGridView.AutoGenerateColumns = false;
            this.opholdDataGridView.DataSource = ophold;
        }

        public Ophold SelectedOphold
        {
            get { return this.selectedOphold; }
            set
            {
                this.selectedOphold = value;
                this.okButton.Enabled = SelectedOphold != null;
            }
        }

        private void OpholdDataGridViewSelectionChanged(object sender, EventArgs e)
        {
            if (this.opholdDataGridView.SelectedRows.Count > 0)
            {
                SelectedOphold = this.opholdDataGridView.SelectedRows[0].DataBoundItem as Ophold;
            }
            else
            {
                SelectedOphold = null;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void annullerButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}