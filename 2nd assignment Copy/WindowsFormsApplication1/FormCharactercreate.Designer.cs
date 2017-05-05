namespace WindowsFormsApplication1
{
    partial class FormCharactercreate
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
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Txt_CharacterName = new System.Windows.Forms.TextBox();
            this.Gbox_Gender = new System.Windows.Forms.GroupBox();
            this.RdoGenderFemale = new System.Windows.Forms.RadioButton();
            this.RdoGenderMale = new System.Windows.Forms.RadioButton();
            this.Cbo_Pickclass = new System.Windows.Forms.ComboBox();
            this.Btn_Savecharacter = new System.Windows.Forms.Button();
            this.Gbox_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(1, 13);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(60, 13);
            this.Lbl_Name.TabIndex = 0;
            this.Lbl_Name.Text = "Your Name";
            // 
            // Txt_CharacterName
            // 
            this.Txt_CharacterName.Location = new System.Drawing.Point(67, 10);
            this.Txt_CharacterName.Name = "Txt_CharacterName";
            this.Txt_CharacterName.Size = new System.Drawing.Size(100, 20);
            this.Txt_CharacterName.TabIndex = 1;
            // 
            // Gbox_Gender
            // 
            this.Gbox_Gender.Controls.Add(this.RdoGenderFemale);
            this.Gbox_Gender.Controls.Add(this.RdoGenderMale);
            this.Gbox_Gender.Location = new System.Drawing.Point(4, 45);
            this.Gbox_Gender.Name = "Gbox_Gender";
            this.Gbox_Gender.Size = new System.Drawing.Size(200, 46);
            this.Gbox_Gender.TabIndex = 2;
            this.Gbox_Gender.TabStop = false;
            this.Gbox_Gender.Text = "Your Gender";
            // 
            // RdoGenderFemale
            // 
            this.RdoGenderFemale.AutoSize = true;
            this.RdoGenderFemale.Location = new System.Drawing.Point(63, 20);
            this.RdoGenderFemale.Name = "RdoGenderFemale";
            this.RdoGenderFemale.Size = new System.Drawing.Size(59, 17);
            this.RdoGenderFemale.TabIndex = 1;
            this.RdoGenderFemale.TabStop = true;
            this.RdoGenderFemale.Text = "Female";
            this.RdoGenderFemale.UseVisualStyleBackColor = true;
            // 
            // RdoGenderMale
            // 
            this.RdoGenderMale.AutoSize = true;
            this.RdoGenderMale.Checked = true;
            this.RdoGenderMale.Location = new System.Drawing.Point(9, 20);
            this.RdoGenderMale.Name = "RdoGenderMale";
            this.RdoGenderMale.Size = new System.Drawing.Size(48, 17);
            this.RdoGenderMale.TabIndex = 0;
            this.RdoGenderMale.TabStop = true;
            this.RdoGenderMale.Text = "Male";
            this.RdoGenderMale.UseVisualStyleBackColor = true;
            // 
            // Cbo_Pickclass
            // 
            this.Cbo_Pickclass.FormattingEnabled = true;
            this.Cbo_Pickclass.Items.AddRange(new object[] {
            "SunSinger",
            "StormCaller",
            "VoidWalker",
            "SunBreaker",
            "Striker",
            "Defender",
            "GunSlinger",
            "NightStalker",
            "BladeDancer"});
            this.Cbo_Pickclass.Location = new System.Drawing.Point(13, 109);
            this.Cbo_Pickclass.Name = "Cbo_Pickclass";
            this.Cbo_Pickclass.Size = new System.Drawing.Size(121, 21);
            this.Cbo_Pickclass.TabIndex = 3;
            this.Cbo_Pickclass.Text = "Pick A Class";
            // 
            // Btn_Savecharacter
            // 
            this.Btn_Savecharacter.Location = new System.Drawing.Point(67, 170);
            this.Btn_Savecharacter.Name = "Btn_Savecharacter";
            this.Btn_Savecharacter.Size = new System.Drawing.Size(167, 68);
            this.Btn_Savecharacter.TabIndex = 4;
            this.Btn_Savecharacter.Text = "Create ";
            this.Btn_Savecharacter.UseVisualStyleBackColor = true;
            this.Btn_Savecharacter.Click += new System.EventHandler(this.Btn_Savecharacter_Click);
            // 
            // FormCharactercreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 283);
            this.Controls.Add(this.Btn_Savecharacter);
            this.Controls.Add(this.Cbo_Pickclass);
            this.Controls.Add(this.Gbox_Gender);
            this.Controls.Add(this.Txt_CharacterName);
            this.Controls.Add(this.Lbl_Name);
            this.Name = "FormCharactercreate";
            this.Text = "Create Character";
            this.Load += new System.EventHandler(this.FormCharactercreate_Load);
            this.Gbox_Gender.ResumeLayout(false);
            this.Gbox_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.TextBox Txt_CharacterName;
        private System.Windows.Forms.GroupBox Gbox_Gender;
        private System.Windows.Forms.RadioButton RdoGenderFemale;
        private System.Windows.Forms.RadioButton RdoGenderMale;
        private System.Windows.Forms.ComboBox Cbo_Pickclass;
        private System.Windows.Forms.Button Btn_Savecharacter;
    }
}