using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSolutions___Prototype1___SB
{
    class ProjectHandler
    {
        //fields
        private int ID;
        private string formTitle;
        private string buttonName;

        //This class determines "context" for the Create and Edit Project Screens. Each screen is an instance of the same form,
        //with their visual differences and functionality being determined by this class.

        //Sets Form and Button names
        public ProjectHandler(int ID)
        {
            this.ID = ID;
            if(ID == 0)
            {
                this.formTitle = "Create Project";
                this.buttonName = "Create Project";
            }
            else
            {
                this.formTitle = "Edit Project";
                this.buttonName = "Edit Project";
            }
        }

        //Returns the Form Title.
        public string getTitle()
        {
            return formTitle;
        }

        //Returns the Button Name.
        public string getButton()
        {
            return buttonName;
        }

        //Returns the current context ID.
        public int getID()
        {
            return ID;
        }

    }
}
