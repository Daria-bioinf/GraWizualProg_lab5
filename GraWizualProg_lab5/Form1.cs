using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraWizualProg_lab5
{
    public partial class FormGame : Form
    {
        enum CellState
        {
            Empty,
            Dydelf
        }
        CellState[,] board;

        int rows = 5;
        int cols = 5;

        int totalDydelfs = 3;
        int foundDydelfs = 0;

        Timer gameTimer;
        int timeLeft = 30;
        public FormGame()
        {
            InitializeComponent();
            CreateBoard();
            StartTimer();
            
        }
        void CreateBoard()
        {

            board = new CellState[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = CellState.Empty;
                }
            }

            Random rand = new Random();

            int placed = 0;
            while (placed < totalDydelfs)
            {
                int r = rand.Next(rows);
                int c = rand.Next(cols);
                if (board[r, c] == CellState.Empty)
                {
                    board[r, c] = CellState.Dydelf;
                    placed++;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Button btn = new Button();

                    btn.Width = 50;
                    btn.Height = 50;

                    btn.Left = j * 50;
                    btn.Top = i * 50;
                    btn.Tag = new Point(i, j);

                    btn.Click += Btn_Click;

                    this.Controls.Add(btn);
                }
            }

           
        }


        void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            Point p = (Point)btn.Tag;

            int row = p.X;
            int col = p.Y;


            if (board[row, col] == CellState.Dydelf)
            {
                btn.Text = "Dydelf!";
                foundDydelfs++;
                //MessageBox.Show("You found Dydelf!");

            }
            else
            {
                btn.Text = "Empty";
            }
            btn.Enabled = false;

            if (foundDydelfs == totalDydelfs)
                {
                    MessageBox.Show("Congratulations! You found all Dydelfs!");
                }
        }

        void StartTimer()
        {
            gameTimer = new Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        void GameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;

            this.Text = "Time: " + timeLeft;
            if (timeLeft <= 0)
            {
                gameTimer.Stop();
                MessageBox.Show("Time's up! You found " + foundDydelfs + " out of " + totalDydelfs + " Dydelfs.");
                DisableAllButtons();
            }

        }
        
        void DisableAllButtons()
        {
            foreach (Control c in this.Controls) {
                if (c is Button)
                {
                    c.Enabled = false;
                }

            }
        }
        private void FormGame_Load(object sender, EventArgs e)
        {

        }
    }
}
