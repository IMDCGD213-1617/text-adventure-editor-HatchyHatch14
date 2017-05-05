namespace WindowsFormsApplication1
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.Lbl_GameName = new System.Windows.Forms.Label();
            this.Btn_CreateCharacter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Options = new System.Windows.Forms.Button();
            this.Btn_Build = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_GameName
            // 
            this.Lbl_GameName.AutoSize = true;
            this.Lbl_GameName.Location = new System.Drawing.Point(13, 13);
            this.Lbl_GameName.Name = "Lbl_GameName";
            this.Lbl_GameName.Size = new System.Drawing.Size(101, 13);
            this.Lbl_GameName.TabIndex = 0;
            this.Lbl_GameName.Text = "RPG Editor for Chris";
            // 
            // Btn_CreateCharacter
            // 
            this.Btn_CreateCharacter.Location = new System.Drawing.Point(16, 61);
            this.Btn_CreateCharacter.Name = "Btn_CreateCharacter";
            this.Btn_CreateCharacter.Size = new System.Drawing.Size(105, 23);
            this.Btn_CreateCharacter.TabIndex = 1;
            this.Btn_CreateCharacter.Text = "Create Character";
            this.Btn_CreateCharacter.UseVisualStyleBackColor = true;
            this.Btn_CreateCharacter.Click += new System.EventHandler(this.Btn_CreateCharacter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Btn_Options
            // 
            this.Btn_Options.Location = new System.Drawing.Point(158, 61);
            this.Btn_Options.Name = "Btn_Options";
            this.Btn_Options.Size = new System.Drawing.Size(105, 23);
            this.Btn_Options.TabIndex = 2;
            this.Btn_Options.Text = "Save";
            this.Btn_Options.UseVisualStyleBackColor = true;
            this.Btn_Options.Click += new System.EventHandler(this.Btn_Options_Click);
            // 
            // Btn_Build
            // 
            this.Btn_Build.Location = new System.Drawing.Point(292, 61);
            this.Btn_Build.Name = "Btn_Build";
            this.Btn_Build.Size = new System.Drawing.Size(118, 23);
            this.Btn_Build.TabIndex = 3;
            this.Btn_Build.Text = "Build Locations";
            this.Btn_Build.UseVisualStyleBackColor = true;
            this.Btn_Build.Click += new System.EventHandler(this.Btn_Build_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Build);
            this.Controls.Add(this.Btn_Options);
            this.Controls.Add(this.Btn_CreateCharacter);
            this.Controls.Add(this.Lbl_GameName);
            this.Name = "Frm_Menu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Frm_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_GameName;
        private System.Windows.Forms.Button Btn_CreateCharacter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Options;
        private System.Windows.Forms.Button Btn_Build;
    }
}

