using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormBuildlocations : Form
    {
        public FormBuildlocations()
        {
            InitializeComponent();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {

            Room newRoom = new Room();

            //Checks and Reads back the information for the room/description/items/exits
            string
            output = "Room Name: " + Txt_RoomName.Text;
            newRoom.Name = Txt_RoomName.Text;
            MessageBox.Show(output);

            
            output = "\nRoom Description: " + Txt_RoomDescription.Text;
            newRoom.Name = Txt_RoomDescription.Text;
            MessageBox.Show(output);
        
            
            output = "\nItems in the Room: " + Txt_RoomItems.Text;
            newRoom.Name = Txt_RoomItems.Text;
            MessageBox.Show(output);

            
            output = "\nExits in the Room: " + Txt_RoomExits.Text;
            newRoom.Name = Txt_RoomExits.Text;
            MessageBox.Show(output);
            
            Frm_Menu.saveData.Rooms.Add(newRoom);
        }

        private void FormBuildlocations_Load(object sender, EventArgs e)
        {

        }
    }
}
