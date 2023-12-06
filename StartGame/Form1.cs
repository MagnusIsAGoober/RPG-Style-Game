using MyRPG;
using System.Windows.Forms;

namespace StartGame
{
    public partial class Form1 : Form
    {
        /*
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 3;
        int speed = 7;
        int projectileSpeed = 5;
        Random randNum = new Random();        
        List<PictureBox> ProjectileList = new List<PictureBox>();
        */

        private Player player;
        private Enemy currentEnemy;
        private Random random;
        private const int maxPlayerAttackDMG = 10;
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
            player = new Player()
            {
                Name = playerName
            };

            //Init the random class
            random = new Random();

            //Display the playername and hide the game button
            StartGameBtn.Visible = false;
            tblActionLayout.Visible = true;
            gbGameView.Visible = true;

            //Write out the start game text to the textbox
            tbGameLog.Text = ("Welcome " + playerName + "!" + "." + Environment.NewLine);

            //set up current enemy
            currentEnemy = new Enemy("Giant Crab");

            //write the text that we encountered the enemy
            tbGameLog.AppendText(playerName + " You have encountered a " + currentEnemy.Name + "!" + Environment.NewLine + "What would you like to do?" + Environment.NewLine);
        }
        private void PerformAction(string Action)
        {
            //check action
            switch(Action)
            {
                case "1":
                    //Write out the attack text
                    tbGameLog.AppendText("You used single attack on the " + currentEnemy.Name + Environment.NewLine);

                    // Attack the enemy
                    currentEnemy.GetsHit(random.Next(1, maxPlayerAttackDMG));
                    break;
                case "2":
                    //Write out the multi attack text
                    tbGameLog.AppendText("You used multi attack on the " + currentEnemy.Name + Environment.NewLine);

                    // Loop three times to perform the multi attack
                    for (int i = 0; i < 3; i++)
                    {
                        currentEnemy.GetsHit(random.Next(1, maxPlayerAttackDMG));

                        //check if enemy is dead
                        if (currentEnemy.IsDead == true)
                        {
                            break;
                        }

                    }
                    break;
                case "3":
                    //Write out the guard text
                    tbGameLog.AppendText("You use guard!" + Environment.NewLine);

                    // set that the player guarding is true
                    player.IsGuarding = true;
                    break;
                case "4":
                    //Write out the heal text
                    tbGameLog.AppendText("You use heal!" + Environment.NewLine);

                    // set that the player guarding is true
                    player.Heal(random.Next(1, 15));
                    break;
                default: 
                    break;
            }

            //check if enemy is dead
            if (!currentEnemy.IsDead)
            {
                //have the enemy attack the player and show via txt
                tbGameLog.AppendText(currentEnemy.Name + " Attacks the player, " + player.Name + " has " + player.Health + " health remaining" + Environment.NewLine);
            }

        
        }
        private void BtnAttack_Click(object sender, EventArgs e)
        {
            PerformAction("1");
        }
        private void btnMulti_Click(object sender, EventArgs e)
        {
            PerformAction("2");
        }

        private void btnGuard_Click(object sender, EventArgs e)
        {
            PerformAction("3");
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            PerformAction("4");
        }


        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void MainTimerEvent(object sender, EventArgs e)
        {

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
            }
            */
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }

    }
}