using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    //This saves the information stored in the text boxes of the build room part accordingly
    public class Information
    {
        private string roomname;
        private string roomdescription;
        private string roomitems;
        private string roomexits;

        public string RoomName
        {
            get { return roomname; }
            set { roomname = value; }
        }

        public string RoomDescription
        {
            get { return roomdescription; }
            set { roomdescription = value; }
        }

        public string RoomItems
        {
            get { return roomitems; }
            set { roomitems = value; }
        }

        public string RoomExits
        {
            get { return roomexits; }
            set { roomexits = value; }
        }
    }
}
