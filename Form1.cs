using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOXOXO
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }
        public int player = 2;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;


        private void button_click(object sender, EventArgs e)
        {


            Button button = (Button)sender;
            {
                if (button.Text == "")
                    if (player % 2 == 0)
                    {
                        button.Text = "X";
                        player++;
                        turns++;
                    }
                    else
                    {
                        button.Text = "O";
                        player++;
                        turns++;
                    }
                if (CheckDraw() == true)
                {
                    MessageBox.Show("Nereseno");
                    sd++;
                    NewGame();
                }
                if (checkWinner()== true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("X won!!");
                        s1++;
                        NewGame();
                    }
                    else
                    {
                        MessageBox.Show("O won!!");
                        s2++;
                        NewGame();
                    }
                }
            }

        }
        private void Form_Load(object sender, EventArgs e)
        {
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draws.Text = "Nereseno: " + sd;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void NewGame()
        {

            player = 2;
            turns = 0;
            A01.Text = A02.Text = A03.Text = A11.Text = A12.Text = A13.Text = A21.Text = A22.Text = A23.Text = "";
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draws.Text = "Draws: " + sd;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        bool CheckDraw()
        {
            if ((turns == 9)&&checkWinner()==false)
                return true;
            else
                return false;
        }
            bool checkWinner()
            {
                //horizontalna provera
                if ((A01.Text == A02.Text) && (A02.Text == A03.Text) && A01.Text != "")
                    return true;
               else if ((A11.Text == A12.Text) && (A12.Text == A13.Text) && A11.Text != "")
                    return true;
              else  if ((A21.Text == A22.Text) && (A22.Text == A23.Text) && A21.Text != "")
                    return true;
                //vertikalna provera
                if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
                    return true;
             else   if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && A02.Text != "")
                    return true;
             else   if ((A03.Text == A13.Text) && (A13.Text == A23.Text) && A03.Text != "")
                    return true;
                //dijagonalna provera
                if ((A01.Text == A12.Text) && (A12.Text == A23.Text) && A01.Text != "")
                    return true;
                else if ((A03.Text == A12.Text) && (A12.Text == A21.Text) && A03.Text != "")
                    return true;
                else
                    return false;
            
            }

        private void button11_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();
        }
    }
}
