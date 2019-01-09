using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace Ships
{
    public partial class GameWindow : Form
    {
        private ITransport ship;

        private System.Timers.Timer delayTimer;
        private System.Timers.Timer moveTimer;

        private Direction dirX = Direction.None;
        private Direction dirY = Direction.None;

        private bool gameStarted = false;

        public GameWindow()
        {
            InitializeComponent();
        }

        private void CreateWarship()
        {
            Random rnd = new Random();
            ship = new Warship(rnd.Next(60, 100), rnd.Next(300, 500), Color.Gray);
            ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), drawingArea.Width, drawingArea.Height);
            Draw();
        }

        private void CreateCruiser()
        {
            Random rnd = new Random();
            ship = new Cruiser(rnd.Next(90, 200), rnd.Next(200, 400), Color.Gray, Color.Red, true);
            ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), drawingArea.Width, drawingArea.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(drawingArea.Width, drawingArea.Height);
            Graphics g = Graphics.FromImage(bmp);
            ship.DrawTransport(g);
            drawingArea.Image = bmp;
        }

        private void SetDelayTimer()
        {
            delayTimer = new System.Timers.Timer(1000 / 60);
            delayTimer.Elapsed += DelayTimerElapsed;
            delayTimer.AutoReset = true;
            delayTimer.Enabled = false;
        }

        private void SetMoveTimer()
        {
            moveTimer = new System.Timers.Timer(1000 / 3);
            moveTimer.Elapsed += MoveTimerElapsed;
            moveTimer.AutoReset = true;
            moveTimer.Enabled = false;
        }

        private void DelayTimerElapsed(object sender, ElapsedEventArgs e)
        {
            moveTimer.Start();
            MoveTimerElapsed(null, null);
            delayTimer.Stop();
        }

        private void MoveTimerElapsed(object sender, ElapsedEventArgs e)
        {
            ship.MoveTransport(dirX);
            ship.MoveTransport(dirY);
            Draw();
        }

        private void btnWarship_Click(object sender, EventArgs e)
        {
            CreateWarship();
            SetDelayTimer();
            SetMoveTimer();
            gameStarted = true;
        }

        private void btnCruiser_Click(object sender, EventArgs e)
        {
            CreateCruiser();
            SetDelayTimer();
            SetMoveTimer();
            gameStarted = true;
        }
        
        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (!gameStarted) return;
            switch (e.KeyCode)
            {
                case Keys.A: dirX = Direction.Left; break;
                case Keys.D: dirX = Direction.Right; break;
                case Keys.W: dirY = Direction.Up; break;
                case Keys.S: dirY = Direction.Down; break;
                default: return;
            }
            if (!delayTimer.Enabled && !moveTimer.Enabled)
                delayTimer.Start();
        }

        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (!gameStarted) return;
            if (e.KeyCode == Keys.A && dirX == Direction.Left
                || e.KeyCode == Keys.D && dirX == Direction.Right)
                dirX = Direction.None;
            else if (e.KeyCode == Keys.W && dirY == Direction.Up
                || e.KeyCode == Keys.S && dirY == Direction.Down)
                dirY = Direction.None;
            else return;
            if (dirX == Direction.None && dirY == Direction.None) moveTimer.Stop();
        }
    }
}
