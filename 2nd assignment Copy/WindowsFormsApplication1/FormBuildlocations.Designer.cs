namespace WindowsFormsApplication1
{
    partial class FormBuildlocations
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
            this.Lbl_RoomName = new System.Windows.Forms.Label();
            this.Txt_RoomName = new System.Windows.Forms.TextBox();
            this.Lbl_RoomDescription = new System.Windows.Forms.Label();
            this.Txt_RoomDescription = new System.Windows.Forms.TextBox();
            this.Lbl_Items = new System.Windows.Forms.Label();
            this.Txt_RoomItems = new System.Windows.Forms.TextBox();
            this.Lbl_Exits = new System.Windows.Forms.Label();
            this.Txt_RoomExits = new System.Windows.Forms.TextBox();
            this.Btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_RoomName
            // 
            this.Lbl_RoomName.AutoSize = true;
            this.Lbl_RoomName.Location = new System.Drawing.Point(18, 16);
            this.Lbl_RoomName.Name = "Lbl_RoomName";
            this.Lbl_RoomName.Size = new System.Drawing.Size(66, 13);
            this.Lbl_RoomName.TabIndex = 0;
            this.Lbl_RoomName.Text = "Room Name";
            // 
            // Txt_RoomName
            // 
            this.Txt_RoomName.Location = new System.Drawing.Point(19, 32);
            this.Txt_RoomName.Name = "Txt_RoomName";
            this.Txt_RoomName.Size = new System.Drawing.Size(347, 20);
            this.Txt_RoomName.TabIndex = 1;
            // 
            // Lbl_RoomDescription
            // 
            this.Lbl_RoomDescription.AutoSize = true;
            this.Lbl_RoomDescription.Location = new System.Drawing.Point(16, 96);
            this.Lbl_RoomDescription.Name = "Lbl_RoomDescription";
            this.Lbl_RoomDescription.Size = new System.Drawing.Size(91, 13);
            this.Lbl_RoomDescription.TabIndex = 2;
            this.Lbl_RoomDescription.Text = "Room Description";
            // 
            // Txt_RoomDescription
            // 
            this.Txt_RoomDescription.Location = new System.Drawing.Point(19, 112);
            this.Txt_RoomDescription.Name = "Txt_RoomDescription";
            this.Txt_RoomDescription.Size = new System.Drawing.Size(347, 20);
            this.Txt_RoomDescription.TabIndex = 3;
            // 
            // Lbl_Items
            // 
            this.Lbl_Items.AutoSize = true;
            this.Lbl_Items.Location = new System.Drawing.Point(18, 183);
            this.Lbl_Items.Name = "Lbl_Items";
            this.Lbl_Items.Size = new System.Drawing.Size(92, 13);
            this.Lbl_Items.TabIndex = 4;
            this.Lbl_Items.Text = "Items in the Room";
            // 
            // Txt_RoomItems
            // 
            this.Txt_RoomItems.Location = new System.Drawing.Point(19, 199);
            this.Txt_RoomItems.Multiline = true;
            this.Txt_RoomItems.Name = "Txt_RoomItems";
            this.Txt_RoomItems.Size = new System.Drawing.Size(335, 175);
            this.Txt_RoomItems.TabIndex = 5;
            // 
            // Lbl_Exits
            // 
            this.Lbl_Exits.AutoSize = true;
            this.Lbl_Exits.Location = new System.Drawing.Point(18, 400);
            this.Lbl_Exits.Name = "Lbl_Exits";
            this.Lbl_Exits.Size = new System.Drawing.Size(89, 13);
            this.Lbl_Exits.TabIndex = 6;
            this.Lbl_Exits.Text = "Exits in the Room";
            // 
            // Txt_RoomExits
            // 
            this.Txt_RoomExits.Location = new System.Drawing.Point(19, 416);
            this.Txt_RoomExits.Multiline = true;
            this.Txt_RoomExits.Name = "Txt_RoomExits";
            this.Txt_RoomExits.Size = new System.Drawing.Size(335, 98);
            this.Txt_RoomExits.TabIndex = 7;
            // 
            // Btn_save
            // 
            this.Btn_save.Location = new System.Drawing.Point(123, 531);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(134, 57);
            this.Btn_save.TabIndex = 8;
            this.Btn_save.Text = "Create\r\n\r\n";
            this.Btn_save.UseVisualStyleBackColor = true;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // FormBuildlocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 600);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.Txt_RoomExits);
            this.Controls.Add(this.Lbl_Exits);
            this.Controls.Add(this.Txt_RoomItems);
            this.Controls.Add(this.Lbl_Items);
            this.Controls.Add(this.Txt_RoomDescription);
            this.Controls.Add(this.Lbl_RoomDescription);
            this.Controls.Add(this.Txt_RoomName);
            this.Controls.Add(this.Lbl_RoomName);
            this.Name = "FormBuildlocations";
            this.Text = "FormBuildlocations";
            this.Load += new System.EventHandler(this.FormBuildlocations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_RoomName;
        private System.Windows.Forms.TextBox Txt_RoomName;
        private System.Windows.Forms.Label Lbl_RoomDescription;
        private System.Windows.Forms.TextBox Txt_RoomDescription;
        private System.Windows.Forms.Label Lbl_Items;
        private System.Windows.Forms.TextBox Txt_RoomItems;
        private System.Windows.Forms.Label Lbl_Exits;
        private System.Windows.Forms.TextBox Txt_RoomExits;
        private System.Windows.Forms.Button Btn_save;
    }
}