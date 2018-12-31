using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace Ships
{
    public partial class GameWindow : Form
    {
        private Battleship ship;

        private System.Timers.Timer delayTimer;
        private System.Timers.Timer moveTimer;

        private Direction dirX = Direction.None;
        private Direction dirY = Direction.None;

        public GameWindow()
        {
            InitializeComponent();
            CreateBattleship();
            SetDelayTimer();
            SetMoveTimer();
        }

        private void CreateBattleship()
        {
            Random rnd = new Random();
            ship = new Battleship(rnd.Next(60, 100), rnd.Next(300, 500), Color.White);
            ship.SetPos(rnd.Next(10, 100), rnd.Next(10, 100), drawingArea.Width, drawingArea.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(drawingArea.Width, drawingArea.Height);
            Graphics g = Graphics.FromImage(bmp);
            ship.DrawBattleship(g);
            drawingArea.Image = bmp;
        }

        private void SetDelayTimer()
        {
            delayTimer = new System.Timers.Timer(1000 / 60);
            delayTimer.Elapsed += DelayTimerElapsed;
            delayTimer.AutoReset = true;
        }

        private void SetMoveTimer()
        {
            moveTimer = new System.Timers.Timer(1000 / 3);
            moveTimer.Elapsed += MoveTimerElapsed;
            moveTimer.AutoReset = true;
        }

        private void DelayTimerElapsed(object sender, ElapsedEventArgs e)
        {
            moveTimer.Start();
            MoveTimerElapsed(null, null);
            delayTimer.Stop();
        }

        private void MoveTimerElapsed(object sender, ElapsedEventArgs e)
        {
            ship.MoveBattleship(dirX);
            ship.MoveBattleship(dirY);
            Draw();
        }

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Left): dirX = Direction.Left; break;
                case (Keys.Right): dirX = Direction.Right; break;
                case (Keys.Up): dirY = Direction.Up; break;
                case (Keys.Down): dirY = Direction.Down; break;
                default: return;
            }
            if (!delayTimer.Enabled && !moveTimer.Enabled)
                delayTimer.Start();
        }

        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && dirX == Direction.Left
                || e.KeyCode == Keys.Right && dirX == Direction.Right)
                dirX = Direction.None;
            else if (e.KeyCode == Keys.Up && dirY == Direction.Up
                || e.KeyCode == Keys.Down && dirY == Direction.Down)
                dirY = Direction.None;
            else return;
            if (dirX == Direction.None && dirY == Direction.None) moveTimer.Stop();
        }
    }
}
