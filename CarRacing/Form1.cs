using System.Xml.Serialization;


namespace CarRacing
{
    public partial class CarRacing : Form
    {
        //Boolean isClick = false;
        int ClickedButton = 0;
        int winner = 0;
        int player1init = 18;
        int player2init = 18;
        int player3init = 18;
        int player4init = 18;
        public CarRacing()
        {
            InitializeComponent();
        }
        public void win()
        {
            //if (player1init == 844)
            //{
            //    winner = 1;
            //    MessageBox.Show("Player " + "1" + " wins!");
            //}
            //else if (player2init == 844)
            //{
            //    winner = 2;
            //    MessageBox.Show("Player " + "2" + " wins!");
            //}
            //else if (player3init == 844)
            //{
            //    winner = 3;
            //    MessageBox.Show("Player " + "3" + " wins!");
            //}
            //else if (player4init == 844)
            //{
            //    winner = 4;
            //    MessageBox.Show("Player " + "4" + " wins!");
            //}
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //public isClick(int buttonid)
        //{

        //}
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            ClickedButton = 1;
            button2.BackColor = Color.Green;
            //turns rest to white
            button4.BackColor = Color.White;
            button3.BackColor = Color.White;
            Player4.BackColor = Color.White;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClickedButton = 2;
            button4.BackColor = Color.Green;
            //turns rest to white
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            Player4.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClickedButton = 3;
            button3.BackColor = Color.Green;
            //turns rest to white
            button4.BackColor = Color.White;
            button2.BackColor = Color.White;
            Player4.BackColor = Color.White;
        }

        private void Player4_Click(object sender, EventArgs e)
        {
            ClickedButton = 4;
            Player4.BackColor = Color.Green;
            //turns rest to white
            button4.BackColor = Color.White;
            button3.BackColor = Color.White;
            button2.BackColor = Color.White;
        }


        private void StartButton_Click(object sender, EventArgs e)
        {



            Random random1 = new Random();
            Random random2 = new Random();
            Random random3 = new Random();
            Random random4 = new Random();

            while (true)
            {

                player1init += random1.Next(1, 10);
                player1pic.Location = new Point(player1init, 244);
                Application.DoEvents();
                Thread.Sleep(2);

                player2init += random2.Next(1, 10);
                player2pic.Location = new Point(player2init, 362);
                Application.DoEvents();
                Thread.Sleep(2);

                player3init += random3.Next(1, 10);
                player3pic.Location = new Point(player3init, 479);
                Application.DoEvents();
                Thread.Sleep(2);

                player4init += random4.Next(1, 10);
                player4pic.Location = new Point(player4init, 585);
                Application.DoEvents();
                Thread.Sleep(2);
                if (ClickedButton > 0)
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    Player4.Enabled = false;
                    Application.DoEvents();
                    if (player1init >= 844 && ClickedButton == 1)
                    {
                        winner = 1;
                        MessageBox.Show("Player " + "1" + " won! You Were Correct!");
                    }
                    else if (player2init >= 844 && ClickedButton == 2)
                    {
                        winner = 2;
                        MessageBox.Show("Player " + "2" + " won! You Were Correct!");
                    }
                    else if (player3init >= 844 && ClickedButton == 3)
                    {
                        winner = 3;
                        MessageBox.Show("Player " + "3" + " won! You Were Correct!");
                    }
                    else if (player4init >= 844 && ClickedButton == 4)
                    {
                        winner = 4;
                        MessageBox.Show("Player " + "4" + " won! You Were Correct!");
                    }


                    if (player1init >= 844 || player2init >= 844 || player3init >= 844 || player4init >= 844)
                    {
                        break;
                    }



                }
                else if (ClickedButton == 0)
                {
                    MessageBox.Show("Please Select a Player!");
                  break;
                }



            }
            if (winner != ClickedButton)
            {
                MessageBox.Show("You Were Wrong! Try Again!");
            }
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            Player4.Enabled = true;

            ClickedButton = 0;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            Player4.BackColor = Color.White;

            player1init = 18;
            player2init = 18;
            player3init = 18;
            player4init = 18;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
