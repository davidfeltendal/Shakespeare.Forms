namespace Shakespeare.Forms.Views
{
    partial class JournalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.journalDataGridView = new System.Windows.Forms.DataGridView();
            this.Tekst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.journalButton = new System.Windows.Forms.Button();
            this.horizontalLine1 = new System.Windows.Forms.Misc.HorizontalLine();
            this.banner = new Shakespeare.Forms.Views.Banner();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.journalDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.journalButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.horizontalLine1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 356);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // journalDataGridView
            // 
            this.journalDataGridView.AllowUserToAddRows = false;
            this.journalDataGridView.AllowUserToDeleteRows = false;
            this.journalDataGridView.AllowUserToResizeRows = false;
            this.journalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.journalDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.journalDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.journalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.journalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tekst,
            this.Dato,
            this.kilde});
            this.journalDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.journalDataGridView.Location = new System.Drawing.Point(3, 3);
            this.journalDataGridView.MultiSelect = false;
            this.journalDataGridView.Name = "journalDataGridView";
            this.journalDataGridView.ReadOnly = true;
            this.journalDataGridView.RowHeadersVisible = false;
            this.journalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.journalDataGridView.Size = new System.Drawing.Size(618, 319);
            this.journalDataGridView.TabIndex = 0;
            // 
            // Tekst
            // 
            this.Tekst.DataPropertyName = "Tekst";
            this.Tekst.HeaderText = "Tekst";
            this.Tekst.Name = "Tekst";
            this.Tekst.ReadOnly = true;
            // 
            // Dato
            // 
            this.Dato.DataPropertyName = "DateTime";
            this.Dato.HeaderText = "Dato";
            this.Dato.Name = "Dato";
            this.Dato.ReadOnly = true;
            // 
            // kilde
            // 
            this.kilde.DataPropertyName = "Kilde";
            this.kilde.HeaderText = "Kilde";
            this.kilde.Name = "kilde";
            this.kilde.ReadOnly = true;
            // 
            // journalButton
            // 
            this.journalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.journalButton.Location = new System.Drawing.Point(546, 330);
            this.journalButton.Name = "journalButton";
            this.journalButton.Size = new System.Drawing.Size(75, 23);
            this.journalButton.TabIndex = 1;
            this.journalButton.Text = "Luk";
            this.journalButton.UseVisualStyleBackColor = true;
            this.journalButton.Click += new System.EventHandler(this.journalButton_Click);
            // 
            // horizontalLine1
            // 
            this.horizontalLine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.horizontalLine1.Location = new System.Drawing.Point(0, 325);
            this.horizontalLine1.Margin = new System.Windows.Forms.Padding(0);
            this.horizontalLine1.MaximumSize = new System.Drawing.Size(0, 2);
            this.horizontalLine1.Name = "horizontalLine1";
            this.horizontalLine1.Size = new System.Drawing.Size(624, 2);
            this.horizontalLine1.TabIndex = 2;
            this.horizontalLine1.Text = "horizontalLine1";
            // 
            // banner
            // 
            this.banner.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.banner.Description = "Her kan du se patientens journal";
            this.banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.banner.Image = global::Shakespeare.Forms.Properties.Resources.Logo_v2;
            this.banner.Location = new System.Drawing.Point(0, 0);
            this.banner.MaximumSize = new System.Drawing.Size(0, 85);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(624, 85);
            this.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.banner.TabIndex = 1;
            this.banner.Title = "Journal";
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "JournalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Journal";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.journalDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Banner banner;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView journalDataGridView;
        private System.Windows.Forms.Button journalButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tekst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilde;
        private System.Windows.Forms.Misc.HorizontalLine horizontalLine1;

    }
}