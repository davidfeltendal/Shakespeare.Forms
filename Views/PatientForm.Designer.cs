using System.Windows.Forms;

namespace Shakespeare.Forms.Views
{
    partial class PatientForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tlfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.adresseTextBox = new System.Windows.Forms.TextBox();
            this.cprLabel = new System.Windows.Forms.Label();
            this.fornavnLabel = new System.Windows.Forms.Label();
            this.efternavnLabel = new System.Windows.Forms.Label();
            this.adresseLabel = new System.Windows.Forms.Label();
            this.postnrLabel = new System.Windows.Forms.Label();
            this.tlfLabel = new System.Windows.Forms.Label();
            this.buttonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.annullerButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.findPatientButton = new System.Windows.Forms.Button();
            this.cprMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.postnrMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.byLabel = new System.Windows.Forms.Label();
            this.byTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.fornavnTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.efternavnTextBox = new System.Windows.Forms.TextBox();
            this.banner = new Shakespeare.Forms.Views.Banner();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.buttonsFlowLayoutPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel8, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel7, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.cprLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.fornavnLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.efternavnLabel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.adresseLabel, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.postnrLabel, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.tlfLabel, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.buttonsFlowLayoutPanel, 2, 6);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel4, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel6, 1, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 85);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(624, 356);
            this.tableLayoutPanel.TabIndex = 12;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.tlfMaskedTextBox, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(65, 253);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(318, 44);
            this.tableLayoutPanel8.TabIndex = 5;
            // 
            // tlfMaskedTextBox
            // 
            this.tlfMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlfMaskedTextBox.Location = new System.Drawing.Point(3, 12);
            this.tlfMaskedTextBox.Mask = "00000000";
            this.tlfMaskedTextBox.Name = "tlfMaskedTextBox";
            this.tlfMaskedTextBox.PromptChar = ' ';
            this.tlfMaskedTextBox.ReadOnly = true;
            this.tlfMaskedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlfMaskedTextBox.Size = new System.Drawing.Size(312, 20);
            this.tlfMaskedTextBox.TabIndex = 7;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.adresseTextBox, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(65, 153);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(318, 44);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // adresseTextBox
            // 
            this.adresseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.adresseTextBox.Location = new System.Drawing.Point(3, 12);
            this.adresseTextBox.Name = "adresseTextBox";
            this.adresseTextBox.ReadOnly = true;
            this.adresseTextBox.Size = new System.Drawing.Size(312, 20);
            this.adresseTextBox.TabIndex = 4;
            // 
            // cprLabel
            // 
            this.cprLabel.AutoSize = true;
            this.cprLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cprLabel.Location = new System.Drawing.Point(3, 0);
            this.cprLabel.Name = "cprLabel";
            this.cprLabel.Size = new System.Drawing.Size(56, 50);
            this.cprLabel.TabIndex = 0;
            this.cprLabel.Text = "CPR-nr.:";
            this.cprLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fornavnLabel
            // 
            this.fornavnLabel.AutoSize = true;
            this.fornavnLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fornavnLabel.Location = new System.Drawing.Point(3, 50);
            this.fornavnLabel.Name = "fornavnLabel";
            this.fornavnLabel.Size = new System.Drawing.Size(56, 50);
            this.fornavnLabel.TabIndex = 1;
            this.fornavnLabel.Text = "Fornavn:";
            this.fornavnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efternavnLabel
            // 
            this.efternavnLabel.AutoSize = true;
            this.efternavnLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.efternavnLabel.Location = new System.Drawing.Point(3, 100);
            this.efternavnLabel.Name = "efternavnLabel";
            this.efternavnLabel.Size = new System.Drawing.Size(56, 50);
            this.efternavnLabel.TabIndex = 2;
            this.efternavnLabel.Text = "Efternavn:";
            this.efternavnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // adresseLabel
            // 
            this.adresseLabel.AutoSize = true;
            this.adresseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adresseLabel.Location = new System.Drawing.Point(3, 150);
            this.adresseLabel.Name = "adresseLabel";
            this.adresseLabel.Size = new System.Drawing.Size(56, 50);
            this.adresseLabel.TabIndex = 3;
            this.adresseLabel.Text = "Adresse:";
            this.adresseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // postnrLabel
            // 
            this.postnrLabel.AutoSize = true;
            this.postnrLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postnrLabel.Location = new System.Drawing.Point(3, 200);
            this.postnrLabel.Name = "postnrLabel";
            this.postnrLabel.Size = new System.Drawing.Size(56, 50);
            this.postnrLabel.TabIndex = 4;
            this.postnrLabel.Text = "Post-nr.:";
            this.postnrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlfLabel
            // 
            this.tlfLabel.AutoSize = true;
            this.tlfLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlfLabel.Location = new System.Drawing.Point(3, 250);
            this.tlfLabel.Name = "tlfLabel";
            this.tlfLabel.Size = new System.Drawing.Size(56, 50);
            this.tlfLabel.TabIndex = 6;
            this.tlfLabel.Text = "Tlf.:";
            this.tlfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonsFlowLayoutPanel
            // 
            this.buttonsFlowLayoutPanel.Controls.Add(this.annullerButton);
            this.buttonsFlowLayoutPanel.Controls.Add(this.okButton);
            this.buttonsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.buttonsFlowLayoutPanel.Location = new System.Drawing.Point(389, 322);
            this.buttonsFlowLayoutPanel.Name = "buttonsFlowLayoutPanel";
            this.buttonsFlowLayoutPanel.Size = new System.Drawing.Size(232, 31);
            this.buttonsFlowLayoutPanel.TabIndex = 15;
            // 
            // annullerButton
            // 
            this.annullerButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annullerButton.Location = new System.Drawing.Point(154, 3);
            this.annullerButton.Name = "annullerButton";
            this.annullerButton.Size = new System.Drawing.Size(75, 23);
            this.annullerButton.TabIndex = 9;
            this.annullerButton.Text = "Annuller";
            this.annullerButton.UseVisualStyleBackColor = true;
            this.annullerButton.Click += new System.EventHandler(this.annullerButton_Click);
            // 
            // okButton
            // 
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(73, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.findPatientButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cprMaskedTextBox, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(65, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(318, 44);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // findPatientButton
            // 
            this.findPatientButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.findPatientButton.Enabled = false;
            this.findPatientButton.Location = new System.Drawing.Point(240, 10);
            this.findPatientButton.Name = "findPatientButton";
            this.findPatientButton.Size = new System.Drawing.Size(75, 23);
            this.findPatientButton.TabIndex = 1;
            this.findPatientButton.Text = "Find";
            this.findPatientButton.UseVisualStyleBackColor = true;
            this.findPatientButton.Click += new System.EventHandler(this.findPatientButton_Click);
            // 
            // cprMaskedTextBox
            // 
            this.cprMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cprMaskedTextBox.Location = new System.Drawing.Point(3, 12);
            this.cprMaskedTextBox.Mask = "000000-9999";
            this.cprMaskedTextBox.Name = "cprMaskedTextBox";
            this.cprMaskedTextBox.PromptChar = ' ';
            this.cprMaskedTextBox.Size = new System.Drawing.Size(231, 20);
            this.cprMaskedTextBox.TabIndex = 0;
            this.cprMaskedTextBox.TextChanged += new System.EventHandler(this.CprMaskedTextBox_TextChanged);
            this.cprMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cprMaskedTextBox_KeyDown);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel4.Controls.Add(this.postnrMaskedTextBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.byLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.byTextBox, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(65, 203);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(318, 44);
            this.tableLayoutPanel4.TabIndex = 16;
            // 
            // postnrMaskedTextBox
            // 
            this.postnrMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.postnrMaskedTextBox.Location = new System.Drawing.Point(3, 12);
            this.postnrMaskedTextBox.Mask = "0000";
            this.postnrMaskedTextBox.Name = "postnrMaskedTextBox";
            this.postnrMaskedTextBox.PromptChar = ' ';
            this.postnrMaskedTextBox.ReadOnly = true;
            this.postnrMaskedTextBox.Size = new System.Drawing.Size(138, 20);
            this.postnrMaskedTextBox.TabIndex = 0;
            // 
            // byLabel
            // 
            this.byLabel.AutoSize = true;
            this.byLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.byLabel.Location = new System.Drawing.Point(147, 0);
            this.byLabel.Name = "byLabel";
            this.byLabel.Size = new System.Drawing.Size(22, 44);
            this.byLabel.TabIndex = 1;
            this.byLabel.Text = "By:";
            this.byLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // byTextBox
            // 
            this.byTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.byTextBox.Location = new System.Drawing.Point(175, 12);
            this.byTextBox.Name = "byTextBox";
            this.byTextBox.ReadOnly = true;
            this.byTextBox.Size = new System.Drawing.Size(140, 20);
            this.byTextBox.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.fornavnTextBox, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(65, 53);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(318, 44);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // fornavnTextBox
            // 
            this.fornavnTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fornavnTextBox.Location = new System.Drawing.Point(3, 12);
            this.fornavnTextBox.Name = "fornavnTextBox";
            this.fornavnTextBox.ReadOnly = true;
            this.fornavnTextBox.Size = new System.Drawing.Size(312, 20);
            this.fornavnTextBox.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.efternavnTextBox, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(65, 103);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(318, 44);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // efternavnTextBox
            // 
            this.efternavnTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.efternavnTextBox.Location = new System.Drawing.Point(3, 12);
            this.efternavnTextBox.Name = "efternavnTextBox";
            this.efternavnTextBox.ReadOnly = true;
            this.efternavnTextBox.Size = new System.Drawing.Size(312, 20);
            this.efternavnTextBox.TabIndex = 3;
            // 
            // banner
            // 
            this.banner.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.banner.Description = "Find en patient via CPR-nr. Patientens oplysninger kommer direkte fra CPR-registr" +
    "et og er derfor altid friske.";
            this.banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.banner.Image = global::Shakespeare.Forms.Properties.Resources.Logo_v2;
            this.banner.Location = new System.Drawing.Point(0, 0);
            this.banner.MaximumSize = new System.Drawing.Size(0, 85);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(624, 85);
            this.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.banner.TabIndex = 0;
            this.banner.Title = "Patientoplysninger";
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.annullerButton;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patientoplysninger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatientForm_FormClosing);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.buttonsFlowLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Banner banner;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.MaskedTextBox tlfMaskedTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox adresseTextBox;
        private System.Windows.Forms.Label cprLabel;
        private System.Windows.Forms.Label fornavnLabel;
        private System.Windows.Forms.Label efternavnLabel;
        private System.Windows.Forms.Label adresseLabel;
        private System.Windows.Forms.Label postnrLabel;
        private System.Windows.Forms.Label tlfLabel;
        private System.Windows.Forms.FlowLayoutPanel buttonsFlowLayoutPanel;
        private System.Windows.Forms.Button annullerButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button findPatientButton;
        private System.Windows.Forms.MaskedTextBox cprMaskedTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.MaskedTextBox postnrMaskedTextBox;
        private System.Windows.Forms.Label byLabel;
        private System.Windows.Forms.TextBox byTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox fornavnTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox efternavnTextBox;





    }
}