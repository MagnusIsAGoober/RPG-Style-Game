namespace MyGame
{
    public partial class MainScene : Form
    {
        public MainScene()
        {
            InitializeComponent();
        }

        bool MoveUp, MoveDown, MoveLeft, MoveRight;

        int moveSpeed = 8;
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void KeyIsPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                MoveUp = true;
            }
            if (e.KeyCode == Keys.S)
            {
                MoveDown = true;
            }
            if (e.KeyCode == Keys.A)
            {
                MoveLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                MoveRight = true;
            }
        }

        private void PerTick(object sender, EventArgs e)
        {
            if (MoveUp == true)
            {
                PlayerPictureBox.Top -= moveSpeed;
            }
            if (MoveDown == true)
            {
                PlayerPictureBox.Top += moveSpeed;
            }
            if (MoveLeft == true)
            {
                PlayerPictureBox.Left -= moveSpeed;
            }
            if (MoveRight == true)
            {
                PlayerPictureBox.Left += moveSpeed;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                MoveUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                MoveDown = false;
            }
            if (e.KeyCode == Keys.A)
            {
                MoveLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                MoveRight = false;
            }
        }
    }
}