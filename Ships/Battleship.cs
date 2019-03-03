using System.Drawing;

namespace Ships
{
    class Battleship
    {
        private const int battleshipWidth = 230;
        private const int battleshipHeight = 60;

        private float startPosX;
        private float startPosY;

        private int pictureWidth;
        private int pictureHeight;

        private Direction dirX = Direction.Right;

        public int MaxSpeed { private set; get; }

        public float Weight { private set; get; }

        public Color Color { private set; get; }

        public Battleship(int maxSpeed, float weight, Color color)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            Color = color;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveBattleship(Direction direction)
        {
            if (direction == Direction.None) return;
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Up:
                    if (_startPosY - step > 0) _startPosY -= step;
                    else _startPosY = 0;
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - _battleshipHeight) _startPosY += step;
                    else _startPosY = _pictureHeight - _battleshipHeight;
                    break;
                case Direction.Left:
                    dirX = Direction.Left;
                    if (_startPosX - step > 0) _startPosX -= step;
                    else _startPosX = 0;
                    break;
                case Direction.Right:
                    dirX = Direction.Right;
                    if (_startPosX + step < _pictureWidth - _battleshipWidth) _startPosX += step;
                    else _startPosX = _pictureWidth - _battleshipWidth;
                    break;
            }
        }

        public void DrawBattleship(Graphics g)
        {
            int stemPosX = 0;
            int sign = 0;
            switch (dirX)
            {
                case (Direction.Left):
                    stemPosX = _battleshipWidth;
                    sign = -1;
                    break;
                case (Direction.Right):
                    stemPosX = 0;
                    sign = 1;
                    break;
            }
            Brush brush = new SolidBrush(Color);
            Point point1 = new Point((int)_startPosX + stemPosX, (int)_startPosY + 54);
            Point point2 = new Point((int)_startPosX + stemPosX + sign * 10, (int)_startPosY + 60);
            Point point3 = new Point((int)_startPosX + stemPosX + sign * 180, (int)_startPosY + 60);
            Point point4 = new Point((int)_startPosX + stemPosX + sign * 190, (int)_startPosY + 54);
            Point point5 = new Point((int)_startPosX + stemPosX + sign * 108, (int)_startPosY + 54);
            Point point6 = new Point((int)_startPosX + stemPosX + sign * 100, (int)_startPosY + 50);
            Point point7 = new Point((int)_startPosX + stemPosX + sign * 230, (int)_startPosY + 46);
            Point point8 = new Point((int)_startPosX + stemPosX + sign * 230, (int)_startPosY + 44);
            Point point9 = new Point((int)_startPosX + stemPosX + sign * 74, (int)_startPosY + 44);
            Point point10 = new Point((int)_startPosX + stemPosX + sign * 66, (int)_startPosY + 30);
            Point point11 = new Point((int)_startPosX + stemPosX + sign * 54, (int)_startPosY + 30);
            Point point12 = new Point((int)_startPosX + stemPosX + sign * 48, (int)_startPosY + 42);
            Point point13 = new Point((int)_startPosX + stemPosX + sign * 40, (int)_startPosY + 42);
            Point point14 = new Point((int)_startPosX + stemPosX + sign * 34, (int)_startPosY + 54);
            Point[] points = { point1, point2, point3, point4, point5, point6, point6, point7, point8, point9, point10, point11, point12, point13, point14 };
            g.FillPolygon(brush, points);
            Pen pen = new Pen(Color);
            g.DrawLine(pen, (int)_startPosX + stemPosX + sign * 60, (int)_startPosY + 30,
                (int)_startPosX + stemPosX + sign * 60, (int)_startPosY);
        }
    }
}
