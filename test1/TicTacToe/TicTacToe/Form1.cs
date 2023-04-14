using System.CodeDom;
using System.Reflection;

namespace TicTacToe
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int turn = 0;
        private void Check()
        {
            bool isWinnerDefined = false;
            if (a1.Text == a2.Text && a2.Text == a3.Text && a1.Text != " "
                || b1.Text == b2.Text && b2.Text == b3.Text && b1.Text != " "
                || c1.Text == c2.Text && c2.Text == c3.Text && c1.Text != " "
                || a1.Text == b1.Text && b1.Text == c1.Text && a1.Text != " "
                || a2.Text == b2.Text && b2.Text == c2.Text && a2.Text != " "
                || a3.Text == b3.Text && b3.Text == c3.Text && a3.Text != " "
                || a1.Text == b2.Text && b2.Text == c3.Text && a1.Text != " "
                || a3.Text == b2.Text && b2.Text == c1.Text && a3.Text != " ")
            {
                isWinnerDefined = true;
            }

            if (isWinnerDefined)
            {
                string winner = turn % 2 == 1 ? "X" : "O";
                MessageBox.Show("The winner is " + winner + "! Press OK to restart!");
                Restart();
            }
            else if (turn == 9)
            {
                MessageBox.Show("It's a draw! Press OK to restart!");
                Restart();
            }
        }

        private void Restart()
        {
            foreach (Control button in tableLayoutPanel1.Controls.OfType<Button>())
            {
                button.Text = " ";
            }

            turn = 0;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == " ")
            {
                button.Text = turn % 2 == 0 ? "X" : "O";
                turn++;
                Check();
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}