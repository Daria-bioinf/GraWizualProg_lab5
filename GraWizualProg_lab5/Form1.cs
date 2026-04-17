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
            Dydelf,
            Szop,
            Krokodyl
        }

        CellState[,] board;

        int rows;
        int cols;

        int totalDydelfs;
        int totalSzops;
        int totalKrokodyl;

        int foundDydelfs = 0;

        int timeLeft;
        Timer gameTimer;

        bool krokodylActive = false;
        Button krokodylButton = null;
        Timer krokodylTimer;


        public FormGame(int r, int c, int t, int d, int k, int s)
        {
            InitializeComponent();

            rows = r;
            cols = c;
            timeLeft = t;

            totalDydelfs = d;
            totalKrokodyl = k;
            totalSzops = s;


            labelTime.Text = "Time: " + timeLeft;

            CreateBoard();
            StartTimer();
        }

        void CreateBoard()
        {
            board = new CellState[rows, cols];


            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    board[i, j] = CellState.Empty;

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


            int placedSzops = 0;
            while (placedSzops < totalSzops)
            {
                int r = rand.Next(rows);
                int c = rand.Next(cols);

                if (board[r, c] == CellState.Empty)
                {
                    board[r, c] = CellState.Szop;
                    placedSzops++;
                }
            }


            int placedKrokodyl = 0;
            while (placedKrokodyl < totalKrokodyl)
            {
                int r = rand.Next(rows);
                int c = rand.Next(cols);

                if (board[r, c] == CellState.Empty)
                {
                    board[r, c] = CellState.Krokodyl;
                    placedKrokodyl++;
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
                    btn.Top = i * 50 + 60;

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
                btn.Enabled = false;

                if (foundDydelfs == totalDydelfs)
                {
                    gameTimer.Stop();
                    MessageBox.Show("Wygrana!");
                    DisableAllButtons();
                }
            }
            else if (board[row, col] == CellState.Szop)
            {
                btn.Text = "🦝";
                HandleSzop(row, col);
                btn.Enabled = false;
            }
            else if (board[row, col] == CellState.Krokodyl)
            {
                btn.Text = "🐊";

                if (!krokodylActive)
                {
                    krokodylActive = true;
                    krokodylButton = btn;
                    StartKrokodylTimer();
                }
                else
                {
                    krokodylTimer.Stop();
                    btn.Text = "";
                    krokodylActive = false;
                    krokodylButton = null;
                }
            }
            else
            {
                btn.Text = "Empty";
                btn.Enabled = false;
            }
        }

        void StartTimer()
        {
            gameTimer = new Timer();
            gameTimer.Interval = 1000;

            gameTimer.Tick += (s, e) =>
            {
                timeLeft--;
                labelTime.Text = "Time: " + timeLeft;
            };
            gameTimer.Start();
        }

        void GameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            labelTime.Text = "Time: " + timeLeft;

            if (timeLeft <= 0)
            {
                gameTimer.Stop();
                //MessageBox.Show("Przegrałeś (czas)");
                //DisableAllButtons();
                MessageBox.Show("tick");
            }
        }

        void StartKrokodylTimer()
        {
            krokodylTimer = new Timer();
            krokodylTimer.Interval = 2000;

            krokodylTimer.Tick += (s, e) =>
            {
                krokodylTimer.Stop();

                if (krokodylActive)
                {
                    MessageBox.Show("Zjadł cię krokodyl 🐊");
                    gameTimer.Stop();
                    DisableAllButtons();
                }
            };

            krokodylTimer.Start();
        }

        void HandleSzop(int row, int col)
        {
            Timer t = new Timer();
            t.Interval = 2000;

            t.Tick += (s, ev) =>
            {
                CloseCell(row, col);

                for (int i = row - 1; i <= row + 1; i++)
                {
                    for (int j = col - 1; j <= col + 1; j++)
                    {
                        if (i >= 0 && i < rows && j >= 0 && j < cols)
                            CloseCell(i, j);
                    }
                }

                t.Stop();
            };

            t.Start();
        }

        void CloseCell(int row, int col)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button btn)
                {
                    Point p = (Point)btn.Tag;

                    if (p.X == row && p.Y == col)
                    {
                        btn.Text = "";
                        btn.Enabled = true;
                    }
                }
            }
        }

        void DisableAllButtons()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                    c.Enabled = false;
            }
        }

        void ReturnToMenu()
        {
            Timer t = new Timer();
            t.Interval = 9000; 

            t.Tick += (s, e) =>
            {
                t.Stop();

                FormStart menu = new FormStart();
                menu.Show();

                this.Close();
            };

            t.Start();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }
    }
}
