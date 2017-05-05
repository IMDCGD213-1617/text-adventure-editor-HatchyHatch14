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
    public partial class FormCharactercreate : Form
    {
        public FormCharactercreate()
        {
            InitializeComponent();
        }


        private void Btn_Savecharacter_Click(object sender, EventArgs e)
        {

            Character newCharacter = new Character();

            //Checks Name of the player
            string output = "";
            output = "Name: " + Txt_CharacterName.Text;
            newCharacter.Name = Txt_CharacterName.Text;
            MessageBox.Show(output);

            //Checks The Gender, if unticked it will assume Female
            output = "Gender: " +
                (string)(this.RdoGenderMale.Checked ? "Male" : "Female");
            newCharacter.isMale = RdoGenderMale.Checked;
            MessageBox.Show(output);

            //Class Selection
            output = "Class: " + Cbo_Pickclass.Text;
            newCharacter.Class = Cbo_Pickclass.Text;
            MessageBox.Show(output);

            Frm_Menu.saveData.Character = newCharacter;
        }

        private void FormCharactercreate_Load(object sender, EventArgs e)
        {

        }
    }
}
