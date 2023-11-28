using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            //Create a keydown event for when a key is pressed in the textbox
            tbNameEntry.KeyDown += (sender, args) =>
            {
                //Check if the key that is pressed is enter
                if (args.KeyCode == Keys.Enter)
                {
                    //Click the submit name button
                    BtnConfirmName.PerformClick();
                }
            };
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {

            lblError.Visible = false;

            //Check if the player supplied a name
            if (!String.IsNullOrWhiteSpace(tbNameEntry.Text))
            {
                //Start the game in the caller form
                caller.StartGame(tbNameEntry.Text.Trim());

                //Close this form
                this.Close();
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
