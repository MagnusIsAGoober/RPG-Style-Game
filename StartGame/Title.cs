namespace StartGame
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            //Create the name form we are going to load
            NameForm nameForm = new NameForm();

            //Display this name as a modal.
            nameForm.ShowDialog();

        }
    }
}