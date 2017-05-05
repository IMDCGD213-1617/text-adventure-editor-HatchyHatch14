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
    //Structs are for holding the class without having a function

    public struct Character
    {
        public string Name;
        public bool isMale;
        public string Class;
    }

    //Like a folder holding Data
    public struct Room
    {
        public string Name;
        public string Description;
        public List<string> Items;
        public List<string> Exits;
    }

    public struct SaveData
    {
        public Character Character;
        public List<Room> Rooms;
    }

    public partial class Frm_Menu : Form
    {

        public static SaveData saveData;

        public Frm_Menu()
        {
            InitializeComponent();

            saveData.Rooms = new List<Room>();
        }

        private void Btn_CreateCharacter_Click(object sender, EventArgs e)
        {
            FormCharactercreate charcreator = new FormCharactercreate();
            charcreator.Show();
        }

        private void Btn_Build_Click(object sender, EventArgs e)
        {
            FormBuildlocations buildlocations = new FormBuildlocations();
            buildlocations.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Options_Click(object sender, EventArgs e)
        {
            //this should try whatever is inside the box and save it but 
            //for whatever reason it doesn't reckonize what exists with naming convensions

            try
            {
                Information info = new Information();
                info.RoomName = Txt_RoomName.Text;
                info.RoomDescription = Txt_RoomDescription.Text;
                info.RoomItems = Txt_RoomItems.Text;
                info.RoomExits = Txt_RoomExits.Text;
                SaveXML.SaveData(info, "data.xml");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
