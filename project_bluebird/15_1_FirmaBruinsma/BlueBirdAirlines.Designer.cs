
namespace _15_1_FirmaBruinsma
{
    partial class BlueBirdAirlines
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
            this.txtNaamInvoeren = new System.Windows.Forms.TextBox();
            this.lbNaam = new System.Windows.Forms.Label();
            this.grbClass = new System.Windows.Forms.GroupBox();
            this.rbtnEconomyClass = new System.Windows.Forms.RadioButton();
            this.rbtnBusinessClass = new System.Windows.Forms.RadioButton();
            this.rbtnFirstClass = new System.Windows.Forms.RadioButton();
            this.cmbStoelnummer = new System.Windows.Forms.ComboBox();
            this.lbStoelnummer = new System.Windows.Forms.Label();
            this.btnStoelToevoegen = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnStoelVrijgeven = new System.Windows.Forms.Button();
            this.lbxEmptySit = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grbClass.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNaamInvoeren
            // 
            this.txtNaamInvoeren.Location = new System.Drawing.Point(6, 32);
            this.txtNaamInvoeren.Name = "txtNaamInvoeren";
            this.txtNaamInvoeren.Size = new System.Drawing.Size(216, 20);
            this.txtNaamInvoeren.TabIndex = 0;
            // 
            // lbNaam
            // 
            this.lbNaam.AutoSize = true;
            this.lbNaam.Location = new System.Drawing.Point(6, 16);
            this.lbNaam.Name = "lbNaam";
            this.lbNaam.Size = new System.Drawing.Size(35, 13);
            this.lbNaam.TabIndex = 1;
            this.lbNaam.Text = "Naam";
            // 
            // grbClass
            // 
            this.grbClass.Controls.Add(this.rbtnEconomyClass);
            this.grbClass.Controls.Add(this.rbtnBusinessClass);
            this.grbClass.Controls.Add(this.rbtnFirstClass);
            this.grbClass.Location = new System.Drawing.Point(6, 116);
            this.grbClass.Name = "grbClass";
            this.grbClass.Size = new System.Drawing.Size(216, 103);
            this.grbClass.TabIndex = 2;
            this.grbClass.TabStop = false;
            this.grbClass.Text = "Class";
            // 
            // rbtnEconomyClass
            // 
            this.rbtnEconomyClass.AutoSize = true;
            this.rbtnEconomyClass.Location = new System.Drawing.Point(6, 71);
            this.rbtnEconomyClass.Name = "rbtnEconomyClass";
            this.rbtnEconomyClass.Size = new System.Drawing.Size(96, 17);
            this.rbtnEconomyClass.TabIndex = 2;
            this.rbtnEconomyClass.TabStop = true;
            this.rbtnEconomyClass.Text = "Economy class";
            this.rbtnEconomyClass.UseVisualStyleBackColor = true;
            this.rbtnEconomyClass.CheckedChanged += new System.EventHandler(this.rbtnEconomyClass_CheckedChanged);
            // 
            // rbtnBusinessClass
            // 
            this.rbtnBusinessClass.AutoSize = true;
            this.rbtnBusinessClass.Location = new System.Drawing.Point(6, 48);
            this.rbtnBusinessClass.Name = "rbtnBusinessClass";
            this.rbtnBusinessClass.Size = new System.Drawing.Size(94, 17);
            this.rbtnBusinessClass.TabIndex = 1;
            this.rbtnBusinessClass.TabStop = true;
            this.rbtnBusinessClass.Text = "Business class";
            this.rbtnBusinessClass.UseVisualStyleBackColor = true;
            this.rbtnBusinessClass.CheckedChanged += new System.EventHandler(this.rbtnBusinessClass_CheckedChanged);
            // 
            // rbtnFirstClass
            // 
            this.rbtnFirstClass.AutoSize = true;
            this.rbtnFirstClass.Location = new System.Drawing.Point(6, 25);
            this.rbtnFirstClass.Name = "rbtnFirstClass";
            this.rbtnFirstClass.Size = new System.Drawing.Size(71, 17);
            this.rbtnFirstClass.TabIndex = 0;
            this.rbtnFirstClass.Text = "First class";
            this.rbtnFirstClass.UseVisualStyleBackColor = true;
            this.rbtnFirstClass.CheckedChanged += new System.EventHandler(this.rbtnFirstClass_CheckedChanged);
            // 
            // cmbStoelnummer
            // 
            this.cmbStoelnummer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStoelnummer.FormattingEnabled = true;
            this.cmbStoelnummer.Location = new System.Drawing.Point(6, 80);
            this.cmbStoelnummer.Name = "cmbStoelnummer";
            this.cmbStoelnummer.Size = new System.Drawing.Size(216, 21);
            this.cmbStoelnummer.TabIndex = 3;
            this.cmbStoelnummer.SelectedIndexChanged += new System.EventHandler(this.cmbStoelnummer_SelectedIndexChanged);
            // 
            // lbStoelnummer
            // 
            this.lbStoelnummer.AutoSize = true;
            this.lbStoelnummer.Location = new System.Drawing.Point(6, 64);
            this.lbStoelnummer.Name = "lbStoelnummer";
            this.lbStoelnummer.Size = new System.Drawing.Size(68, 13);
            this.lbStoelnummer.TabIndex = 4;
            this.lbStoelnummer.Text = "Stoelnummer";
            // 
            // btnStoelToevoegen
            // 
            this.btnStoelToevoegen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStoelToevoegen.Location = new System.Drawing.Point(6, 281);
            this.btnStoelToevoegen.Name = "btnStoelToevoegen";
            this.btnStoelToevoegen.Size = new System.Drawing.Size(216, 41);
            this.btnStoelToevoegen.TabIndex = 5;
            this.btnStoelToevoegen.Text = "Reservering toevoegen";
            this.btnStoelToevoegen.UseVisualStyleBackColor = true;
            this.btnStoelToevoegen.Click += new System.EventHandler(this.btnStoelToevoegen_Click);
            // 
            // btnStoelVrijgeven
            // 
            this.btnStoelVrijgeven.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStoelVrijgeven.Location = new System.Drawing.Point(6, 234);
            this.btnStoelVrijgeven.Name = "btnStoelVrijgeven";
            this.btnStoelVrijgeven.Size = new System.Drawing.Size(216, 41);
            this.btnStoelVrijgeven.TabIndex = 6;
            this.btnStoelVrijgeven.Text = "Stoel vrijmaken";
            this.btnStoelVrijgeven.UseVisualStyleBackColor = true;
            this.btnStoelVrijgeven.Click += new System.EventHandler(this.btnStoelVrijgeven_Click);
            // 
            // lbxEmptySit
            // 
            this.lbxEmptySit.FormattingEnabled = true;
            this.lbxEmptySit.Location = new System.Drawing.Point(6, 32);
            this.lbxEmptySit.Name = "lbxEmptySit";
            this.lbxEmptySit.Size = new System.Drawing.Size(172, 290);
            this.lbxEmptySit.TabIndex = 8;
            this.lbxEmptySit.SelectedIndexChanged += new System.EventHandler(this.lsbStoelenVrij_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbxEmptySit);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 329);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stoelenoverzicht";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Klik op een stoel om aan te passen";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lbNaam);
            this.groupBox2.Controls.Add(this.txtNaamInvoeren);
            this.groupBox2.Controls.Add(this.btnStoelToevoegen);
            this.groupBox2.Controls.Add(this.btnStoelVrijgeven);
            this.groupBox2.Controls.Add(this.lbStoelnummer);
            this.groupBox2.Controls.Add(this.cmbStoelnummer);
            this.groupBox2.Controls.Add(this.grbClass);
            this.groupBox2.Location = new System.Drawing.Point(202, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 329);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stoelinformatie";
            // 
            // BlueBirdAirlines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::_15_1_FirmaBruinsma.Properties.Resources.bluebird;
            this.ClientSize = new System.Drawing.Size(440, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BlueBirdAirlines";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bluebird Airlines";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BlueBirdAirlines_FormClosing);
            this.Load += new System.EventHandler(this.BlueBirdAirlines_Load);
            this.grbClass.ResumeLayout(false);
            this.grbClass.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaamInvoeren;
        private System.Windows.Forms.Label lbNaam;
        private System.Windows.Forms.GroupBox grbClass;
        private System.Windows.Forms.RadioButton rbtnEconomyClass;
        private System.Windows.Forms.RadioButton rbtnBusinessClass;
        private System.Windows.Forms.RadioButton rbtnFirstClass;
        private System.Windows.Forms.ComboBox cmbStoelnummer;
        private System.Windows.Forms.Label lbStoelnummer;
        private System.Windows.Forms.Button btnStoelToevoegen;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnStoelVrijgeven;
        private System.Windows.Forms.ListBox lbxEmptySit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}