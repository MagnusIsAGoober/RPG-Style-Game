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

        public void StartGame(String playerName)
        {
            //Assign the player name
            PlayerName = playerName;

            //Display the playername and hide the game button
            StartGameBtn.Visible = false;
            tblActionLayout.Visible = true;
            tbGameLog.Visible = true;
        }
    }
}