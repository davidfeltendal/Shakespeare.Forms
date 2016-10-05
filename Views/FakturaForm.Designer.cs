namespace Shakespeare.Forms.Views
{
    partial class FakturaForm
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
            System.Windows.Forms.Label momsHeaderLabel;
            System.Windows.Forms.Label subtotalHeaderLabel;
            System.Windows.Forms.Label totalHeaderLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FakturaForm));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cprLabel = new System.Windows.Forms.Label();
            this.patientNavnLabel = new System.Windows.Forms.Label();
            this.adresseLabel = new System.Windows.Forms.Label();
            this.postByLabel = new System.Windows.Forms.Label();
            this.tlfLabel = new System.Windows.Forms.Label();
            this.fakturalinjerDataGridView = new System.Windows.Forms.DataGridView();
            this.navnKolonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stykprisKolonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antalKolonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalKolonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horizontalLine2 = new System.Windows.Forms.Misc.HorizontalLine();
            this.horizontalLine3 = new System.Windows.Forms.Misc.HorizontalLine();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.momsLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.horizontalLine4 = new System.Windows.Forms.Misc.HorizontalLine();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.findPatientStripLabel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.opretBehandlingStripLabel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.visJournalStripLabel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.findTidligereOpholdStripLabel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.personaleoplysingerStripLabel1 = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.annullerButton = new System.Windows.Forms.Button();
            this.gemFakturaButton1 = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.gemFakturaButton = new System.Windows.Forms.Button();
            this.annullerOpholdButton = new System.Windows.Forms.Button();
            this.banner = new Shakespeare.Forms.Views.Banner();
            momsHeaderLabel = new System.Windows.Forms.Label();
            subtotalHeaderLabel = new System.Windows.Forms.Label();
            totalHeaderLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fakturalinjerDataGridView)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // momsHeaderLabel
            // 
            momsHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            momsHeaderLabel.AutoSize = true;
            momsHeaderLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            momsHeaderLabel.Location = new System.Drawing.Point(14, 15);
            momsHeaderLabel.Name = "momsHeaderLabel";
            momsHeaderLabel.Padding = new System.Windows.Forms.Padding(1);
            momsHeaderLabel.Size = new System.Drawing.Size(40, 15);
            momsHeaderLabel.TabIndex = 1;
            momsHeaderLabel.Text = "Moms:";
            // 
            // subtotalHeaderLabel
            // 
            subtotalHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            subtotalHeaderLabel.AutoSize = true;
            subtotalHeaderLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            subtotalHeaderLabel.Location = new System.Drawing.Point(3, 0);
            subtotalHeaderLabel.Name = "subtotalHeaderLabel";
            subtotalHeaderLabel.Padding = new System.Windows.Forms.Padding(1);
            subtotalHeaderLabel.Size = new System.Drawing.Size(51, 15);
            subtotalHeaderLabel.TabIndex = 2;
            subtotalHeaderLabel.Text = "Subtotal:";
            // 
            // totalHeaderLabel
            // 
            totalHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            totalHeaderLabel.AutoSize = true;
            totalHeaderLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            totalHeaderLabel.Location = new System.Drawing.Point(18, 32);
            totalHeaderLabel.Name = "totalHeaderLabel";
            totalHeaderLabel.Padding = new System.Windows.Forms.Padding(1);
            totalHeaderLabel.Size = new System.Drawing.Size(36, 15);
            totalHeaderLabel.TabIndex = 0;
            totalHeaderLabel.Text = "Total:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 624F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 85);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(624, 356);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 290);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.fakturalinjerDataGridView, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.horizontalLine2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.horizontalLine3, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(616, 288);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(610, 76);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Shakespeare.Forms.Properties.Resources.Logo_v2;
            this.pictureBox2.Location = new System.Drawing.Point(503, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.cprLabel);
            this.flowLayoutPanel1.Controls.Add(this.patientNavnLabel);
            this.flowLayoutPanel1.Controls.Add(this.adresseLabel);
            this.flowLayoutPanel1.Controls.Add(this.postByLabel);
            this.flowLayoutPanel1.Controls.Add(this.tlfLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(494, 70);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // cprLabel
            // 
            this.cprLabel.AutoSize = true;
            this.cprLabel.Location = new System.Drawing.Point(1, 1);
            this.cprLabel.Margin = new System.Windows.Forms.Padding(1);
            this.cprLabel.Name = "cprLabel";
            this.cprLabel.Size = new System.Drawing.Size(33, 12);
            this.cprLabel.TabIndex = 4;
            this.cprLabel.Text = "CPR-nr";
            // 
            // patientNavnLabel
            // 
            this.patientNavnLabel.AutoSize = true;
            this.patientNavnLabel.Location = new System.Drawing.Point(1, 15);
            this.patientNavnLabel.Margin = new System.Windows.Forms.Padding(1);
            this.patientNavnLabel.Name = "patientNavnLabel";
            this.patientNavnLabel.Size = new System.Drawing.Size(54, 12);
            this.patientNavnLabel.TabIndex = 0;
            this.patientNavnLabel.Text = "Patient navn";
            // 
            // adresseLabel
            // 
            this.adresseLabel.AutoSize = true;
            this.adresseLabel.Location = new System.Drawing.Point(1, 29);
            this.adresseLabel.Margin = new System.Windows.Forms.Padding(1);
            this.adresseLabel.Name = "adresseLabel";
            this.adresseLabel.Size = new System.Drawing.Size(37, 12);
            this.adresseLabel.TabIndex = 1;
            this.adresseLabel.Text = "Adresse";
            // 
            // postByLabel
            // 
            this.postByLabel.AutoSize = true;
            this.postByLabel.Location = new System.Drawing.Point(1, 43);
            this.postByLabel.Margin = new System.Windows.Forms.Padding(1);
            this.postByLabel.Name = "postByLabel";
            this.postByLabel.Size = new System.Drawing.Size(57, 12);
            this.postByLabel.TabIndex = 2;
            this.postByLabel.Text = "Post-nr og by";
            // 
            // tlfLabel
            // 
            this.tlfLabel.AutoSize = true;
            this.tlfLabel.Location = new System.Drawing.Point(1, 57);
            this.tlfLabel.Margin = new System.Windows.Forms.Padding(1);
            this.tlfLabel.Name = "tlfLabel";
            this.tlfLabel.Size = new System.Drawing.Size(27, 12);
            this.tlfLabel.TabIndex = 3;
            this.tlfLabel.Text = "Tlf-nr";
            // 
            // fakturalinjerDataGridView
            // 
            this.fakturalinjerDataGridView.AllowUserToAddRows = false;
            this.fakturalinjerDataGridView.AllowUserToDeleteRows = false;
            this.fakturalinjerDataGridView.AllowUserToResizeRows = false;
            this.fakturalinjerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fakturalinjerDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.fakturalinjerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fakturalinjerDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.fakturalinjerDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.fakturalinjerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fakturalinjerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.navnKolonne,
            this.stykprisKolonne,
            this.antalKolonne,
            this.subtotalKolonne});
            this.fakturalinjerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fakturalinjerDataGridView.Location = new System.Drawing.Point(3, 87);
            this.fakturalinjerDataGridView.MultiSelect = false;
            this.fakturalinjerDataGridView.Name = "fakturalinjerDataGridView";
            this.fakturalinjerDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.fakturalinjerDataGridView.RowHeadersVisible = false;
            this.fakturalinjerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fakturalinjerDataGridView.Size = new System.Drawing.Size(610, 143);
            this.fakturalinjerDataGridView.TabIndex = 2;
            // 
            // navnKolonne
            // 
            this.navnKolonne.DataPropertyName = "Navn";
            this.navnKolonne.HeaderText = "Navn";
            this.navnKolonne.Name = "navnKolonne";
            this.navnKolonne.ReadOnly = true;
            // 
            // stykprisKolonne
            // 
            this.stykprisKolonne.DataPropertyName = "Stykpris";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            this.stykprisKolonne.DefaultCellStyle = dataGridViewCellStyle1;
            this.stykprisKolonne.HeaderText = "Stykpris";
            this.stykprisKolonne.Name = "stykprisKolonne";
            this.stykprisKolonne.ReadOnly = true;
            // 
            // antalKolonne
            // 
            this.antalKolonne.DataPropertyName = "Antal";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.antalKolonne.DefaultCellStyle = dataGridViewCellStyle2;
            this.antalKolonne.HeaderText = "Antal";
            this.antalKolonne.Name = "antalKolonne";
            this.antalKolonne.ReadOnly = true;
            // 
            // subtotalKolonne
            // 
            this.subtotalKolonne.DataPropertyName = "Subtotal";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0";
            this.subtotalKolonne.DefaultCellStyle = dataGridViewCellStyle3;
            this.subtotalKolonne.HeaderText = "Subtotal";
            this.subtotalKolonne.Name = "subtotalKolonne";
            this.subtotalKolonne.ReadOnly = true;
            // 
            // horizontalLine2
            // 
            this.horizontalLine2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.horizontalLine2.Location = new System.Drawing.Point(0, 82);
            this.horizontalLine2.Margin = new System.Windows.Forms.Padding(0);
            this.horizontalLine2.MaximumSize = new System.Drawing.Size(0, 2);
            this.horizontalLine2.Name = "horizontalLine2";
            this.horizontalLine2.Size = new System.Drawing.Size(616, 2);
            this.horizontalLine2.TabIndex = 3;
            this.horizontalLine2.Text = "horizontalLine2";
            // 
            // horizontalLine3
            // 
            this.horizontalLine3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.horizontalLine3.Location = new System.Drawing.Point(0, 233);
            this.horizontalLine3.Margin = new System.Windows.Forms.Padding(0);
            this.horizontalLine3.MaximumSize = new System.Drawing.Size(0, 2);
            this.horizontalLine3.Name = "horizontalLine3";
            this.horizontalLine3.Size = new System.Drawing.Size(616, 2);
            this.horizontalLine3.TabIndex = 5;
            this.horizontalLine3.Text = "horizontalLine3";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(momsHeaderLabel, 0, 1);
            this.tableLayoutPanel6.Controls.Add(subtotalHeaderLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.subtotalLabel, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.momsLabel, 1, 1);
            this.tableLayoutPanel6.Controls.Add(totalHeaderLabel, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.totalLabel, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.horizontalLine4, 0, 2);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(502, 238);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(111, 47);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.subtotalLabel.Location = new System.Drawing.Point(60, 0);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Padding = new System.Windows.Forms.Padding(1);
            this.subtotalLabel.Size = new System.Drawing.Size(48, 15);
            this.subtotalLabel.TabIndex = 3;
            this.subtotalLabel.Text = "00,00 kr";
            // 
            // momsLabel
            // 
            this.momsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.momsLabel.AutoSize = true;
            this.momsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.momsLabel.Location = new System.Drawing.Point(60, 15);
            this.momsLabel.Name = "momsLabel";
            this.momsLabel.Padding = new System.Windows.Forms.Padding(1);
            this.momsLabel.Size = new System.Drawing.Size(48, 15);
            this.momsLabel.TabIndex = 4;
            this.momsLabel.Text = "00,00 kr";
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalLabel.AutoSize = true;
            this.totalLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalLabel.Location = new System.Drawing.Point(60, 32);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Padding = new System.Windows.Forms.Padding(1);
            this.totalLabel.Size = new System.Drawing.Size(48, 15);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "00,00 kr";
            // 
            // horizontalLine4
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.horizontalLine4, 2);
            this.horizontalLine4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.horizontalLine4.Location = new System.Drawing.Point(0, 30);
            this.horizontalLine4.Margin = new System.Windows.Forms.Padding(0);
            this.horizontalLine4.MaximumSize = new System.Drawing.Size(0, 2);
            this.horizontalLine4.Name = "horizontalLine4";
            this.horizontalLine4.Size = new System.Drawing.Size(111, 2);
            this.horizontalLine4.TabIndex = 6;
            this.horizontalLine4.Text = "horizontalLine4";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findPatientStripLabel,
            this.toolStripSeparator1,
            this.opretBehandlingStripLabel,
            this.toolStripSeparator2,
            this.visJournalStripLabel,
            this.toolStripSeparator3,
            this.findTidligereOpholdStripLabel,
            this.toolStripSeparator4,
            this.personaleoplysingerStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(624, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // findPatientStripLabel
            // 
            this.findPatientStripLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.findPatientStripLabel.Image = ((System.Drawing.Image)(resources.GetObject("findPatientStripLabel.Image")));
            this.findPatientStripLabel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findPatientStripLabel.Name = "findPatientStripLabel";
            this.findPatientStripLabel.Size = new System.Drawing.Size(74, 22);
            this.findPatientStripLabel.Text = "Find patient";
            this.findPatientStripLabel.Click += new System.EventHandler(this.findPatientStripLabel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // opretBehandlingStripLabel
            // 
            this.opretBehandlingStripLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.opretBehandlingStripLabel.Enabled = false;
            this.opretBehandlingStripLabel.Image = ((System.Drawing.Image)(resources.GetObject("opretBehandlingStripLabel.Image")));
            this.opretBehandlingStripLabel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.opretBehandlingStripLabel.Name = "opretBehandlingStripLabel";
            this.opretBehandlingStripLabel.Size = new System.Drawing.Size(104, 22);
            this.opretBehandlingStripLabel.Text = "Opret behandling";
            this.opretBehandlingStripLabel.Click += new System.EventHandler(this.opretBehandlingStripLabel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // visJournalStripLabel
            // 
            this.visJournalStripLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.visJournalStripLabel.Enabled = false;
            this.visJournalStripLabel.Image = ((System.Drawing.Image)(resources.GetObject("visJournalStripLabel.Image")));
            this.visJournalStripLabel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.visJournalStripLabel.Name = "visJournalStripLabel";
            this.visJournalStripLabel.Size = new System.Drawing.Size(66, 22);
            this.visJournalStripLabel.Text = "Vis journal";
            this.visJournalStripLabel.Click += new System.EventHandler(this.visJournalStripLabel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // findTidligereOpholdStripLabel
            // 
            this.findTidligereOpholdStripLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.findTidligereOpholdStripLabel.Enabled = false;
            this.findTidligereOpholdStripLabel.Image = ((System.Drawing.Image)(resources.GetObject("findTidligereOpholdStripLabel.Image")));
            this.findTidligereOpholdStripLabel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findTidligereOpholdStripLabel.Name = "findTidligereOpholdStripLabel";
            this.findTidligereOpholdStripLabel.Size = new System.Drawing.Size(179, 22);
            this.findTidligereOpholdStripLabel.Text = "Find patientens tidligere ophold";
            this.findTidligereOpholdStripLabel.Click += new System.EventHandler(this.findTidligereOpholdStripLabel_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // personaleoplysingerStripLabel1
            // 
            this.personaleoplysingerStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.personaleoplysingerStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("personaleoplysingerStripLabel1.Image")));
            this.personaleoplysingerStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.personaleoplysingerStripLabel1.Name = "personaleoplysingerStripLabel1";
            this.personaleoplysingerStripLabel1.Size = new System.Drawing.Size(135, 22);
            this.personaleoplysingerStripLabel1.Text = "Vis personaleoplysinger";
            this.personaleoplysingerStripLabel1.Click += new System.EventHandler(this.personaleoplysingerStripLabel1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.annullerButton);
            this.flowLayoutPanel2.Controls.Add(this.gemFakturaButton1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 324);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(618, 29);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // annullerButton
            // 
            this.annullerButton.Enabled = false;
            this.annullerButton.Location = new System.Drawing.Point(485, 3);
            this.annullerButton.Name = "annullerButton";
            this.annullerButton.Size = new System.Drawing.Size(130, 23);
            this.annullerButton.TabIndex = 0;
            this.annullerButton.Text = "Slet ophold";
            this.annullerButton.UseVisualStyleBackColor = true;
            this.annullerButton.Click += new System.EventHandler(this.annullerButton_Click);
            // 
            // gemFakturaButton1
            // 
            this.gemFakturaButton1.Enabled = false;
            this.gemFakturaButton1.Location = new System.Drawing.Point(349, 3);
            this.gemFakturaButton1.Name = "gemFakturaButton1";
            this.gemFakturaButton1.Size = new System.Drawing.Size(130, 23);
            this.gemFakturaButton1.TabIndex = 1;
            this.gemFakturaButton1.Text = "Gem faktura som PDF";
            this.gemFakturaButton1.UseVisualStyleBackColor = true;
            this.gemFakturaButton1.Click += new System.EventHandler(this.gemFakturaButton_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Shakespeare.Forms.Properties.Resources.delete;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.ToolTipText = "Slet";
            this.dataGridViewImageColumn1.Width = 104;
            // 
            // gemFakturaButton
            // 
            this.gemFakturaButton.Location = new System.Drawing.Point(0, 0);
            this.gemFakturaButton.Name = "gemFakturaButton";
            this.gemFakturaButton.Size = new System.Drawing.Size(75, 23);
            this.gemFakturaButton.TabIndex = 0;
            // 
            // annullerOpholdButton
            // 
            this.annullerOpholdButton.Location = new System.Drawing.Point(0, 0);
            this.annullerOpholdButton.Name = "annullerOpholdButton";
            this.annullerOpholdButton.Size = new System.Drawing.Size(75, 23);
            this.annullerOpholdButton.TabIndex = 0;
            // 
            // banner
            // 
            this.banner.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.banner.Description = "Administrationssystem til privatehospitalet Shakespeare.";
            this.banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.banner.Image = global::Shakespeare.Forms.Properties.Resources.Logo_v2;
            this.banner.Location = new System.Drawing.Point(0, 0);
            this.banner.MaximumSize = new System.Drawing.Size(0, 85);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(624, 85);
            this.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.banner.TabIndex = 0;
            this.banner.Title = "Velkommen til Shakespeare";
            // 
            // FakturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.banner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FakturaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shakespeare";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fakturalinjerDataGridView)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Banner banner;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label cprLabel;
        private System.Windows.Forms.Label patientNavnLabel;
        private System.Windows.Forms.Label adresseLabel;
        private System.Windows.Forms.Label postByLabel;
        private System.Windows.Forms.Label tlfLabel;
        private System.Windows.Forms.DataGridView fakturalinjerDataGridView;
        private System.Windows.Forms.Misc.HorizontalLine horizontalLine2;
        private System.Windows.Forms.Misc.HorizontalLine horizontalLine3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label momsLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Misc.HorizontalLine horizontalLine4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DataGridViewTextBoxColumn navnKolonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn stykprisKolonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn antalKolonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalKolonne;
        private System.Windows.Forms.ToolStripButton findPatientStripLabel;
        private System.Windows.Forms.ToolStripButton opretBehandlingStripLabel;
        private System.Windows.Forms.ToolStripButton visJournalStripLabel;
        private System.Windows.Forms.ToolStripButton findTidligereOpholdStripLabel;
        private System.Windows.Forms.ToolStripButton personaleoplysingerStripLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button annullerOpholdButton;
        private System.Windows.Forms.Button gemFakturaButton;
        private System.Windows.Forms.Button annullerButton;
        private System.Windows.Forms.Button gemFakturaButton1;

    }
}