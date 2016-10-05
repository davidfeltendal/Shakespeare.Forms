using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Shakespeare.Forms.Models;

namespace Shakespeare.Forms.Views
{
    public partial class JournalForm : Form
    {
        public JournalForm(IEnumerable<Journallinje> journallinjer)
        {
            // Sætter font til Segoe UI (Windows 7 font.)
            Font = SystemFonts.MessageBoxFont;
            InitializeComponent();

            this.journalDataGridView.AutoGenerateColumns = false;
            this.journalDataGridView.DataSource = journallinjer.OrderByDescending(j => j.DateTime).ToList();
        }

        private void journalButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
