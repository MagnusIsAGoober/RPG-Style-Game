using System.Windows.Forms;

namespace StartGame
{
    public partial class Form1 : Form
    {

        public String PlayerName;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            //Create the name form we are going to load
            NameForm nameForm = new NameForm(this);

            //Display this name as a modal.
            nameForm.ShowDialog();

        }
    }
}