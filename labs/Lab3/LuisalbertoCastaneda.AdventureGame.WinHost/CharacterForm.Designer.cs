
namespace LuisalbertoCastaneda.AdventureGame.WinHost
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtBio = new System.Windows.Forms.TextBox();
            this._txtStrength = new System.Windows.Forms.TextBox();
            this._txtIntel = new System.Windows.Forms.TextBox();
            this._cbProfession = new System.Windows.Forms.ComboBox();
            this._cbRace = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._txtAgility = new System.Windows.Forms.TextBox();
            this._txtConstitution = new System.Windows.Forms.TextBox();
            this._txtCharisma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profession";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Race";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Biography";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnSave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(116, 27);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(100, 23);
            this._txtName.TabIndex = 6;
            // 
            // _txtBio
            // 
            this._txtBio.Location = new System.Drawing.Point(116, 143);
            this._txtBio.Name = "_txtBio";
            this._txtBio.Size = new System.Drawing.Size(144, 23);
            this._txtBio.TabIndex = 7;
            // 
            // _txtStrength
            // 
            this._txtStrength.Location = new System.Drawing.Point(116, 182);
            this._txtStrength.Name = "_txtStrength";
            this._txtStrength.Size = new System.Drawing.Size(100, 23);
            this._txtStrength.TabIndex = 8;
            // 
            // _txtIntel
            // 
            this._txtIntel.Location = new System.Drawing.Point(116, 218);
            this._txtIntel.Name = "_txtIntel";
            this._txtIntel.Size = new System.Drawing.Size(100, 23);
            this._txtIntel.TabIndex = 9;
            // 
            // _cbProfession
            // 
            this._cbProfession.FormattingEnabled = true;
            this._cbProfession.Location = new System.Drawing.Point(116, 65);
            this._cbProfession.Name = "_cbProfession";
            this._cbProfession.Size = new System.Drawing.Size(121, 23);
            this._cbProfession.TabIndex = 10;
            // 
            // _cbRace
            // 
            this._cbRace.FormattingEnabled = true;
            this._cbRace.Location = new System.Drawing.Point(116, 101);
            this._cbRace.Name = "_cbRace";
            this._cbRace.Size = new System.Drawing.Size(121, 23);
            this._cbRace.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Strength";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Intelligence";
            // 
            // _txtAgility
            // 
            this._txtAgility.Location = new System.Drawing.Point(116, 275);
            this._txtAgility.Name = "_txtAgility";
            this._txtAgility.Size = new System.Drawing.Size(100, 23);
            this._txtAgility.TabIndex = 14;
            // 
            // _txtConstitution
            // 
            this._txtConstitution.Location = new System.Drawing.Point(116, 312);
            this._txtConstitution.Name = "_txtConstitution";
            this._txtConstitution.Size = new System.Drawing.Size(100, 23);
            this._txtConstitution.TabIndex = 15;
            // 
            // _txtCharisma
            // 
            this._txtCharisma.Location = new System.Drawing.Point(116, 357);
            this._txtCharisma.Name = "_txtCharisma";
            this._txtCharisma.Size = new System.Drawing.Size(100, 23);
            this._txtCharisma.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Agility";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Constitution";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Charisma";
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 396);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._txtCharisma);
            this.Controls.Add(this._txtConstitution);
            this.Controls.Add(this._txtAgility);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._cbRace);
            this.Controls.Add(this._cbProfession);
            this.Controls.Add(this._txtIntel);
            this.Controls.Add(this._txtStrength);
            this.Controls.Add(this._txtBio);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CharacterForm";
            this.Text = "Create New Character";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _txtCharisma;
        private System.Windows.Forms.TextBox _txtConstitution;
        private System.Windows.Forms.TextBox _txtAgility;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _cbRace;
        private System.Windows.Forms.ComboBox _cbProfession;
        private System.Windows.Forms.TextBox _txtIntel;
        private System.Windows.Forms.TextBox _txtStrength;
        private System.Windows.Forms.TextBox _txtBio;
        private System.Windows.Forms.TextBox _txtName;
    }
}