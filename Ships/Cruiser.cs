using System;
using System.Drawing;

namespace Ships
{
    class Cruiser : Warship
    {
        public Color FlagColor { get; private set; }

        private int _numberOfCannons;

        public int NumberOfCannons
        {
            get { return _numberOfCannons; }
            private set { if (value > 0 && value < 4 ) _numberOfCannons = value; }
        }

        public bool Flag { get; private set; }

        public Cruiser(int maxSpeed, float weight, Color mainColor, Color flagColor, bool flag) : base(maxSpeed, weight, mainColor)
        {
            FlagColor = flagColor;
            Flag = flag;
            Random rnd = new Random();
            NumberOfCannons = rnd.Next(1, 4);
        }

        public override void DrawTransport(Graphics g)
        {
            int stemPosX = (int)_startPosX;
            int sign = 0;
            switch (dirX)
            {
                case (Direction.Left):
                    stemPosX += _warshipWidth;
                    sign = -1;
                    break;
                case (Direction.Right):
                    sign = 1;
                    break;
            }
            Brush brush = new SolidBrush(MainColor);
            Point point1 = new Point(stemPosX, (int)_startPosY + 54);
            Point point2 = new Point(stemPosX + sign * 10, (int)_startPosY + 60);
            Point point3 = new Point(stemPosX + sign * 180, (int)_startPosY + 60);
            Point point4 = new Point(stemPosX + sign * 190, (int)_startPosY + 54);
            Point point5 = new Point(stemPosX + sign * 75, (int)_startPosY + 54);
            Point point6 = new Point(stemPosX + sign * 66, (int)_startPosY + 30);
            Point point7 = new Point(stemPosX + sign * 54, (int)_startPosY + 30);
            Point point8 = new Point(stemPosX + sign * 48, (int)_startPosY + 42);
            Point point9 = new Point(stemPosX + sign * 40, (int)_startPosY + 42);
            Point point10 = new Point(stemPosX + sign * 34, (int)_startPosY + 54);
            Point[] points = { point1, point2, point3, point4, point5, point6, point6, point7, point8, point9, point10 };
            g.FillPolygon(brush, points);
            Pen pen = new Pen(MainColor);
            int startPointX = stemPosX + sign * 120;
            for (int i = 1; i <= NumberOfCannons; i++)
            {
                g.DrawLine(pen, startPointX, (int)_startPosY + 54, startPointX, (int)_startPosY + 51);
                g.FillRectangle(brush, startPointX - 2, (int)_startPosY + 48, 5, 3);
                g.DrawLine(pen, startPointX + sign * 2, (int)_startPosY + 49,
                    startPointX + sign * 5, (int)_startPosY + 49);
                startPointX += 20;
            }
            brush = new SolidBrush(FlagColor);
            if (Flag) g.FillRectangle(brush, stemPosX + sign * 60, (int)_startPosY, 10, 6);
            g.DrawLine(pen, stemPosX + sign * 60, (int)_startPosY + 30,
                stemPosX + sign * 60, (int)_startPosY);
        } 
    }
}
