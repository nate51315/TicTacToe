using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private String playerOneName;
        private String playerTwoName;
        private bool gameStart = false;
        private bool x_o = false;
        private char[,] grid;

        public Form1()
        {
            InitializeComponent();
            playerOneName = txtPlayerOne.Text;
            playerTwoName = txtPlayerTwo.Text;
            grid = new char[3,3];
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            gameStart = true;
            clearGrid();
            clearButtons();
        }

        private void clearGrid()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i,j] = ' ';
                }
            }
        }

        private void clearButtons()
        {
            clearGrid();
            btnTopLeft.Text = "";
            btnTopMid.Text = "";
            btnTopRight.Text = "";
            btnMidLeft.Text = "";
            btnMid.Text = "";
            btnMidRight.Text = "";
            btnBotLeft.Text = "";
            btnBotMid.Text = "";
            btnBotRight.Text = "";
        }

        private void displayWinner(char cell)
        {
            if (cell.Equals('O'))
            {
                MessageBox.Show("Winner is player one with " + cell + "'s");
            }
            else if (cell.Equals('X'))
            {
                MessageBox.Show("Winner is player two with " + cell + "'s");
            }
            else
            {
                MessageBox.Show("No Winner ... Tie/Cats Game");
            }
        }

        private void checkForWin()
        {
            if (grid[0, 0].Equals('X') && grid[0, 1].Equals('X') && grid[0, 2].Equals('X')
                || grid[0, 0].Equals('O') && grid[0, 1].Equals('O') && grid[0, 2].Equals('O'))
            {
                gameStart = false;
                displayWinner(grid[0,0]);
            }
            if (grid[1, 0].Equals('X') && grid[1, 1].Equals('X') && grid[1, 2].Equals('X')
                || grid[1, 0].Equals('O') && grid[1, 1].Equals('O') && grid[1, 2].Equals('O'))
            {
                gameStart = false;
                displayWinner(grid[1, 0]);
            }
            if (grid[2, 0].Equals('X') && grid[2, 1].Equals('X') && grid[2, 2].Equals('X')
                || grid[2, 0].Equals('O') && grid[2, 1].Equals('O') && grid[2, 2].Equals('O'))
            {
                gameStart = false;
                displayWinner(grid[2, 0]);
            }
            if (grid[0, 0].Equals('X') && grid[1, 0].Equals('X') && grid[2, 0].Equals('X')
                || grid[0, 0].Equals('O') && grid[1, 0].Equals('O') && grid[2, 0].Equals('O'))
            {
                gameStart = false;
                displayWinner(grid[0, 0]);
            }
            if (grid[0, 1].Equals('X') && grid[1, 1].Equals('X') && grid[2, 1].Equals('X')
                || grid[0, 1].Equals('O') && grid[1, 1].Equals('O') && grid[2, 1].Equals('O'))
            {
                gameStart = false;
                displayWinner(grid[0, 1]);
            }
            if (grid[0, 2].Equals('X') && grid[1, 2].Equals('X') && grid[2, 2].Equals('X')
               || grid[0, 2].Equals('O') && grid[1, 2].Equals('O') && grid[2, 2].Equals('O'))
            {
                gameStart = false;
                displayWinner(grid[0, 2]);
            }
            if (grid[0, 0].Equals('X') && grid[1, 1].Equals('X') && grid[2, 2].Equals('X')
               || grid[0, 0].Equals('O') && grid[1, 1].Equals('O') && grid[2, 2].Equals('O'))
            {
                gameStart = false;
                displayWinner(grid[0, 0]);
            }
            if (grid[2, 0].Equals('X') && grid[1, 1].Equals('X') && grid[0, 2].Equals('X')
               || grid[2, 0].Equals('O') && grid[1, 1].Equals('O') && grid[0, 2].Equals('O'))
            {
                gameStart = false;
                displayWinner(grid[2, 0]);
            }
            if(checkForCatsGame())
            {
                gameStart = false;
                displayWinner('C');
            }
            else
            {
                gameStart = true;
            }
        }

        private Boolean checkForCatsGame()
        {
            int filledCellCount = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(!grid[i,j].Equals(' ') || grid[i,j].Equals(""))
                    {
                        filledCellCount++;
                    }
                }
            }
            if(filledCellCount == 9 && gameStart)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearButtons();
            clearGrid();
            x_o = false;
        }

        private void setGrid(int x, int y, char move)
        {
            grid[x, y] = move;
            checkForWin();
        }

        private void btnTopLeft_Click(object sender, EventArgs e)
        {
            if (gameStart && btnTopLeft.Text.Equals(""))
            {
                if (x_o)
                {
                    btnTopLeft.Text = "X";
                    x_o = false;
                    setGrid(0, 0, 'X');
                }
                else
                {
                    btnTopLeft.Text = "O";
                    x_o = true;
                    setGrid(0, 0, 'O');
                }
            }
        }

        private void btnTopMid_Click(object sender, EventArgs e)
        {
            if (gameStart && btnTopMid.Text.Equals(""))
            {
                if (x_o)
                {
                    btnTopMid.Text = "X";
                    x_o = false;
                    setGrid(0, 1, 'X');
                }
                else
                {
                    btnTopMid.Text = "O";
                    x_o = true;
                    setGrid(0, 1, 'O');
                }
            }
        }

        private void btnTopRight_Click(object sender, EventArgs e)
        {
            if (gameStart && btnTopRight.Text.Equals(""))
            {
                if (x_o)
                {
                    btnTopRight.Text = "X";
                    x_o = false;
                    setGrid(0, 2, 'X');
                }
                else
                {
                    btnTopRight.Text = "O";
                    x_o = true;
                    setGrid(0, 2, 'O');
                }
            }
        }

        private void btnMidLeft_Click(object sender, EventArgs e)
        {
            if (gameStart && btnMidLeft.Text.Equals(""))
            {
                if (x_o)
                {
                    btnMidLeft.Text = "X";
                    x_o = false;
                    setGrid(1, 0, 'X');
                }
                else
                {
                    btnMidLeft.Text = "O";
                    x_o = true;
                    setGrid(1, 0, 'O');
                }
            }
        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            if (gameStart && btnMid.Text.Equals(""))
            {
                if (x_o)
                {
                    btnMid.Text = "X";
                    x_o = false;
                    setGrid(1,1,'X');
                }
                else
                {
                    btnMid.Text = "O";
                    x_o = true;
                    setGrid(1,1,'O');
                }
            }
        }

        private void btnMidRight_Click(object sender, EventArgs e)
        {
            if (gameStart && btnMidRight.Text.Equals(""))
            {
                if (x_o)
                {
                    btnMidRight.Text = "X";
                    x_o = false;
                    setGrid(1,2,'X');
                }
                else
                {
                    btnMidRight.Text = "O";
                    x_o = true;
                    setGrid(1, 2,'O');
                }
            }
        }

        private void btnBotLeft_Click(object sender, EventArgs e)
        {
            if (gameStart && btnBotLeft.Text.Equals(""))
            {
                if (x_o)
                {
                    btnBotLeft.Text = "X";
                    x_o = false;
                    setGrid(2, 0, 'X');
                }
                else
                {
                    btnBotLeft.Text = "O";
                    x_o = true;
                    setGrid(2,0,'O');
                }
            }
        }

        private void btnBotMid_Click(object sender, EventArgs e)
        {
            if (gameStart && btnBotMid.Text.Equals(""))
            {
                if (x_o)
                {
                    btnBotMid.Text = "X";
                    x_o = false;
                    setGrid(2, 1, 'X');
                }
                else
                {
                    btnBotMid.Text = "O";
                    x_o = true;
                    setGrid(2, 1, 'O');
                }
            }
        }

        private void btnBotRight_Click(object sender, EventArgs e)
        {
            if (gameStart && btnBotRight.Text.Equals(""))
            {
                if (x_o)
                {
                    btnBotRight.Text = "X";
                    x_o = false;
                    setGrid(2, 2, 'X');
                }
                else
                {
                    btnBotRight.Text = "O";
                    x_o = true;
                    setGrid(2, 2, 'O');
                }
            }
        }
    }
}
