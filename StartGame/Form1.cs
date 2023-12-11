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

            player.Health = 100;

            //Init the random class
            random = new Random();

            //Display the playername and hide the game button
            StartGameBtn.Visible = false;
            tblActionLayout.Visible = true;
            gbGameView.Visible = true;
            pbHealth.Visible = true;
            lblHealth.Visible = true;


            //Write out the start game text to the textbox
            tbGameLog.Text = ("Welcome " + playerName + "!" + "." + Environment.NewLine);

            //set up current enemy
            currentEnemy = new Enemy("Giant Crab");

            //write the text that we encountered the enemy
            tbGameLog.AppendText(playerName + " You have encountered a " + currentEnemy.Name + "!" + Environment.NewLine + "What would you like to do?" + Environment.NewLine);
        }
        private void PerformAction(string Action)
        {
            if (!player.IsDead)
            {
                int hit_value;
                //check action
                switch (Action)
                {
                    case "1":
                        //Write out the attack text
                        tbGameLog.AppendText("You used single attack on the " + currentEnemy.Name + Environment.NewLine);


                        hit_value = random.Next(1, maxPlayerAttackDMG);

                        // Attack the enemy
                        currentEnemy.GetsHit(hit_value);

                        //write it got hit
                        tbGameLog.AppendText(currentEnemy.Name + " was hit for " + hit_value + " damage! And has " + currentEnemy.Health + " health remaining." + Environment.NewLine);
                        break;
                    case "2":
                        //Write out the multi attack text
                        tbGameLog.AppendText("You used multi attack on the " + currentEnemy.Name + Environment.NewLine);

                        // Loop three times to perform the multi attack
                        for (int i = 0; i < 3; i++)
                        {
                            hit_value = random.Next(1, maxPlayerAttackDMG);

                            // Attack the enemy
                            currentEnemy.GetsHit(hit_value);

                            //write it got hit
                            tbGameLog.AppendText(currentEnemy.Name + " was hit for " + hit_value + " damage! And has " + currentEnemy.Health + " health remaining." + Environment.NewLine);

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

                        int amount_to_heal = random.Next(1, 15);

                        player.Heal(amount_to_heal);
                        //Write out the heal text
                        tbGameLog.AppendText("You use heal!" + Environment.NewLine);

                        tbGameLog.AppendText(player.Name + " was healed for " + amount_to_heal + " Health! You now have" + player.Health + " remaining." + Environment.NewLine);
                        // set that the player guarding is true
                        player.Heal(random.Next(1, 15));
                        break;
                    default:
                        break;
                }


                //check if enemy is dead
                if (!currentEnemy.IsDead)
                {
                    if (player.IsGuarding)
                    {
                        tbGameLog.AppendText(player.Name + " gaurded the blow and was unharmed!" + Environment.NewLine);

                        //remove guard
                        player.IsGuarding = false;
                    }
                    else
                    {
                        //have the enemy attack the player and show via txt
                        player.GetsHit(random.Next(1, currentEnemy.MaxAttackDMG));
                        tbGameLog.AppendText(currentEnemy.Name + " Attacks the player, Leaving the player with " + player.Health + "Health" + Environment.NewLine + Environment.NewLine);

                    }


                }


                //check if player is dead
                if (currentEnemy.IsDead)
                {

                    tbGameLog.AppendText(currentEnemy.Name + " was slain " + Environment.NewLine);

                    //have the enemy attack the player and show via txt
                    if (currentEnemy is Boss)
                    {
                        GameOver("Congrats! " + player.Name + " You have defeated the final boss!" + Environment.NewLine);
                    }
                    else
                    {
                        currentEnemy = new Boss();
                        //write the text that we encountered the boos
                        tbGameLog.AppendText(player.Name + " You have encountered a " + currentEnemy.Name + "!" + Environment.NewLine + "What would you like to do?" + Environment.NewLine);

                    }
                }
                else if (player.IsDead)
                {

                    GameOver("You were slain..." + Environment.NewLine);
                }


                if (player.Health < 0)
                {
                    player.Health = 0;
                }
                else
                {
                    pbHealth.Value = player.Health;
                }
            }
            
            

        }

        private void GameOver(string GameOverText)
        {

            tbGameLog.AppendText(GameOverText);

            StartGameBtn.Visible = true;
            StartGameBtn.Text = "Restart?";

            if (player.Health < 0)
            {
                player.Health = 0;
            }
            else
            {
                pbHealth.Value = player.Health;
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
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void gbGameView_TextChanged(object sender, EventArgs e)
        {
            pbHealth.Value = player.Health;
        }
    }
}