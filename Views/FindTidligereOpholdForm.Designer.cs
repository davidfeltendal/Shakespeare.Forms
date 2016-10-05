using System;

namespace Shakespeare.Forms.Views
{
    partial class FindTidligereOpholdForm
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
            this.opholdDataGridView = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.annullerButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.banner1 = new Shakespeare.Forms.Views.Banner();
            this.patientCprKolonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startKolonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slutKolonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opholdDataGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.opholdDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 356);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // opholdDataGridView
            // 
            this.opholdDataGridView.AllowUserToAddRows = false;
            this.opholdDataGridView.AllowUserToDeleteRows = false;
            this.opholdDataGridView.AllowUserToResizeRows = false;
            this.opholdDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.opholdDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.opholdDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.opholdDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.opholdDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.opholdDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientCprKolonne,
            this.startKolonne,
            this.slutKolonne});
            this.opholdDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opholdDataGridView.Location = new System.Drawing.Point(3, 3);
            this.opholdDataGridView.MultiSelect = false;
            this.opholdDataGridView.Name = "opholdDataGridView";
            this.opholdDataGridView.ReadOnly = true;
            this.opholdDataGridView.RowHeadersVisible = false;
            this.opholdDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.opholdDataGridView.Size = new System.Drawing.Size(618, 315);
            this.opholdDataGridView.TabIndex = 0;
            this.opholdDataGridView.SelectionChanged += new System.EventHandler(this.OpholdDataGridViewSelectionChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.annullerButton);
            this.flowLayoutPanel1.Controls.Add(this.okButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 324);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(618, 29);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // annullerButton
            // 
            this.annullerButton.Location = new System.Drawing.Point(540, 3);
            this.annullerButton.Name = "annullerButton";
            this.annullerButton.Size = new System.Drawing.Size(75, 23);
            this.annullerButton.TabIndex = 1;
            this.annullerButton.Text = "Annuller";
            this.annullerButton.UseVisualStyleBackColor = true;
            this.annullerButton.Click += new System.EventHandler(this.annullerButton_Click);
            // 
            // okButton
            // 
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(459, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // banner1
            // 
            this.banner1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.banner1.Description = "Her kan du finde patientens tidligere ophold.";
            this.banner1.Dock = System.Windows.Forms.DockStyle.Top;
            this.banner1.Image = global::Shakespeare.Forms.Properties.Resources.Logo_v2;
            this.banner1.Location = new System.Drawing.Point(0, 0);
            this.banner1.MaximumSize = new System.Drawing.Size(0, 85);
            this.banner1.Name = "banner1";
            this.banner1.Size = new System.Drawing.Size(624, 85);
            this.banner1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.banner1.TabIndex = 0;
            this.banner1.Title = "Find tidligere ophold";
            // 
            // patientCprKolonne
            // 
            this.patientCprKolonne.DataPropertyName = "PatientCpr";
            this.patientCprKolonne.HeaderText = "Patient";
            this.patientCprKolonne.Name = "patientCprKolonne";
            this.patientCprKolonne.ReadOnly = true;
            // 
            // startKolonne
            // 
            this.startKolonne.DataPropertyName = "Start";
            this.startKolonne.HeaderText = "Opholdets startdato";
            this.startKolonne.Name = "startKolonne";
            this.startKolonne.ReadOnly = true;
            // 
            // slutKolonne
            // 
            this.slutKolonne.DataPropertyName = "Slut";
            this.slutKolonne.HeaderText = "Opholdets slutdato";
            this.slutKolonne.Name = "slutKolonne";
            this.slutKolonne.ReadOnly = true;
            // 
            // FindTidligereOpholdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.banner1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FindTidligereOpholdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find tidligere ophold";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opholdDataGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Banner banner1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView opholdDataGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button annullerButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientCprKolonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn startKolonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn slutKolonne;
    }
}