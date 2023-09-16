namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        private int randomNum;
        private int trys = 3;
        private int tryAgainClicked;
        private int limit = 3;
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            randomNum = rnd.Next(1, 11);
        }

        private void btn_Click(object sender, EventArgs e)
        {

            int num = 0;
            if (txt.Text != String.Empty)
            {
                num = int.Parse(txt.Text);
            }

            if (num == randomNum)
            {
                lbl.Text = "Congratulations! You guessed the number.";
                btn.Enabled = false;
                txt.Enabled = false;
            }
            else
            {
                lbl.Text = "Too bad :(. You didn't guess the number but you can try again.";
                trys--;
                if (trys == 1)
                {
                    label2.Text = $"You have {trys} try";
                }
                else if (trys == 0)
                {
                    label2.Text = "You don't have any more tryes.";
                    btn.Enabled = false;
                    txt.Enabled = false;
                }
                else
                {
                    label2.Text = $"You have {trys} trys";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tryAgain_Click(object sender, EventArgs e)
        {
            tryAgainClicked++;
            btn.Enabled = true;
            txt.Enabled = true;
            trys = 3;
            label2.Text = $"You have {trys} trys";
            lbl.Text = String.Empty;
            Random rnd = new Random();
            randomNum = rnd.Next(1, 11);

            if (tryAgainClicked > limit)
            {
                MessageBoxButtons btns = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("You tried over 9 times do you want to know what is the number ?", "Over 9 trys", btns);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"The current number is {randomNum}", "Current number");
                }
                else
                {
                    limit += 3;
                }
            }
        }
    }
}