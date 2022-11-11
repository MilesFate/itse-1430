namespace CharacterCreator.WinHost
{
    partial class CharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._cbRace = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._cbProfession = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._txtCharisma = new System.Windows.Forms.NumericUpDown();
            this._txtConstitution = new System.Windows.Forms.NumericUpDown();
            this._txtAgility = new System.Windows.Forms.NumericUpDown();
            this._txtIntelligence = new System.Windows.Forms.NumericUpDown();
            this._txtStrength = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._txtBiography = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtConstitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtAgility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // _txtName
            // 
            this._txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtName.Location = new System.Drawing.Point(88, 22);
            this._txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(208, 23);
            this._txtName.TabIndex = 0;
            this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateName);
            // 
            // _cbRace
            // 
            this._cbRace.DisplayMember = "Name";
            this._cbRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbRace.FormattingEnabled = true;
            this._cbRace.Location = new System.Drawing.Point(88, 58);
            this._cbRace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbRace.Name = "_cbRace";
            this._cbRace.Size = new System.Drawing.Size(140, 23);
            this._cbRace.TabIndex = 1;
            this._cbRace.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateCombo);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Race";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Profession";
            // 
            // _cbProfession
            // 
            this._cbProfession.DisplayMember = "Name";
            this._cbProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProfession.FormattingEnabled = true;
            this._cbProfession.Location = new System.Drawing.Point(88, 95);
            this._cbProfession.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbProfession.Name = "_cbProfession";
            this._cbProfession.Size = new System.Drawing.Size(140, 23);
            this._cbProfession.TabIndex = 2;
            this._cbProfession.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateCombo);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._txtCharisma);
            this.groupBox1.Controls.Add(this._txtConstitution);
            this.groupBox1.Controls.Add(this._txtAgility);
            this.groupBox1.Controls.Add(this._txtIntelligence);
            this.groupBox1.Controls.Add(this._txtStrength);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(19, 144);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(195, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attributes";
            // 
            // _txtCharisma
            // 
            this._txtCharisma.Location = new System.Drawing.Point(99, 144);
            this._txtCharisma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._txtCharisma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._txtCharisma.Name = "_txtCharisma";
            this._txtCharisma.Size = new System.Drawing.Size(49, 23);
            this._txtCharisma.TabIndex = 4;
            this._txtCharisma.Tag = "Charisma";
            this._txtCharisma.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _txtConstitution
            // 
            this._txtConstitution.Location = new System.Drawing.Point(99, 114);
            this._txtConstitution.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._txtConstitution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._txtConstitution.Name = "_txtConstitution";
            this._txtConstitution.Size = new System.Drawing.Size(49, 23);
            this._txtConstitution.TabIndex = 3;
            this._txtConstitution.Tag = "Constitution";
            this._txtConstitution.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _txtAgility
            // 
            this._txtAgility.Location = new System.Drawing.Point(99, 84);
            this._txtAgility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._txtAgility.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._txtAgility.Name = "_txtAgility";
            this._txtAgility.Size = new System.Drawing.Size(49, 23);
            this._txtAgility.TabIndex = 2;
            this._txtAgility.Tag = "Agility";
            this._txtAgility.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _txtIntelligence
            // 
            this._txtIntelligence.Location = new System.Drawing.Point(99, 54);
            this._txtIntelligence.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._txtIntelligence.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._txtIntelligence.Name = "_txtIntelligence";
            this._txtIntelligence.Size = new System.Drawing.Size(49, 23);
            this._txtIntelligence.TabIndex = 1;
            this._txtIntelligence.Tag = "Intelligence";
            this._txtIntelligence.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _txtStrength
            // 
            this._txtStrength.Location = new System.Drawing.Point(99, 24);
            this._txtStrength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._txtStrength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._txtStrength.Name = "_txtStrength";
            this._txtStrength.Size = new System.Drawing.Size(49, 23);
            this._txtStrength.TabIndex = 0;
            this._txtStrength.Tag = "Strength";
            this._txtStrength.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this._txtStrength.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateAttribute);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 147);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Charisma";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Constitution";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Agility";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Intelligence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Strength";
            // 
            // _txtBiography
            // 
            this._txtBiography.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtBiography.Location = new System.Drawing.Point(316, 45);
            this._txtBiography.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._txtBiography.Multiline = true;
            this._txtBiography.Name = "_txtBiography";
            this._txtBiography.Size = new System.Drawing.Size(344, 288);
            this._txtBiography.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Biography";
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.CausesValidation = false;
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(587, 359);
            this._btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(88, 27);
            this._btnCancel.TabIndex = 6;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // _btnSave
            // 
            this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSave.Location = new System.Drawing.Point(492, 359);
            this._btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(88, 27);
            this._btnSave.TabIndex = 5;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _errors
            // 
            this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors.ContainerControl = this;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(688, 399);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtBiography);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._cbProfession);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._cbRace);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtCharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtConstitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtAgility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.ComboBox _cbRace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _cbProfession;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown _txtCharisma;
        private System.Windows.Forms.NumericUpDown _txtConstitution;
        private System.Windows.Forms.NumericUpDown _txtAgility;
        private System.Windows.Forms.NumericUpDown _txtIntelligence;
        private System.Windows.Forms.NumericUpDown _txtStrength;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtBiography;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.ErrorProvider _errors;
    }
}