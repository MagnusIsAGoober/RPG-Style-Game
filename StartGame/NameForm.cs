using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartGame
{
    public partial class NameForm : Form
    {

        private Form1 caller;
        public NameForm(Form1 callerForm)
        {
            InitializeComponent();

            //save the reference to the caller
            caller = callerForm;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {

            lblError.Visible = false;

            //Check if the player supplied a name
            if (!String.IsNullOrWhiteSpace(txtBoxNameEntry.Text))
            {
                //Name was given, pass it back to the caller form.
            }
            else
            {
                //The name was not entered
                lblError.Visible = true;
                lblError.Text = "Wha.. Surely you have a name";
            }
        }
    }
}
