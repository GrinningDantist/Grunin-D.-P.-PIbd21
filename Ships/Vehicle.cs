using System.Drawing;

namespace Ships
{
    abstract class Vehicle : ITransport
    {
        protected float startPosX;
        protected float startPosY;

        protected int pictureWidth;
        protected int pictureHeight;

        protected Direction dirX = Direction.Left;

        public int MaxSpeed { protected set; get; }

        public float Weight { protected set; get; }

        public Color MainColor { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            startPosX = x;
            startPosY = y;
            pictureWidth = width;
            pictureHeight = height;
        }

        public abstract void MoveTransport(Direction direction);

        public abstract void DrawTransport(Graphics g);

        public void Repaint(Color color)
        {
            MainColor = color;
        }
    }
}
