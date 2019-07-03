using System;
using System.Drawing;

namespace Ships
{
    class Warship : Vehicle, IComparable<Warship>, IEquatable<Warship>
    {
        protected const int warshipWidth = 230;
        protected const int warshipHeight = 60;

        public Warship(int index, int maxSpeed, float weight, Color mainColor)
        {
            Index = index;
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public Warship(string data, out bool success)
        {
            string[] parameters = data.Split('/');
            if (parameters.Length != 4) { success = false; return; }
            Index = int.Parse(parameters[0]);
            MaxSpeed = int.Parse(parameters[1]);
            Weight = int.Parse(parameters[2]);
            MainColor = Color.FromName(parameters[3]);
            success = true;
        }

        public override void MoveTransport(Direction direction)
        {
            if (direction == Direction.None) return;
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Up:
                    if (startPosY - step > 0) startPosY -= step;
                    else startPosY = 0;
                    break;
                case Direction.Down:
                    if (startPosY + step < pictureHeight - warshipHeight) startPosY += step;
                    else startPosY = pictureHeight - warshipHeight;
                    break;
                case Direction.Left:
                    dirX = Direction.Left;
                    if (startPosX - step > 0) startPosX -= step;
                    else startPosX = 0;
                    break;
                case Direction.Right:
                    dirX = Direction.Right;
                    if (startPosX + step < pictureWidth - warshipWidth) startPosX += step;
                    else startPosX = pictureWidth - warshipWidth;
                    break;
            }
        }

        public override void DrawTransport(Graphics g)
        {
            int stemPosX = GetStemPosX();
            if (stemPosX == -1)
            {
                PrintError(g);
                return;
            }
            DrawBase(g, stemPosX);
            DrawCannon(g, stemPosX);
        }

        protected int GetStemPosX()
        {
            if (dirX == Direction.Left) return warshipWidth;
            else if (dirX == Direction.Right) return 0;
            return -    1;
        }

        protected void PrintError(Graphics g)
        {
            String error = "ОШИБКА: ГОРИЗОНТАЛЬНОЕ НАПРАВЛЕНИЕ " +
                "ЗАДАНО НЕПРАВИЛЬНО";
            Font errorFont = new Font(FontFamily.GenericSansSerif, 8);
            Brush errorBrush = new SolidBrush(Color.Red);
            g.DrawString(error, errorFont, errorBrush, 5, 5);
        }

        protected void DrawBase(Graphics g, int stemPosX)
        {
            Brush brush = new SolidBrush(MainColor);
            Point point1 = new Point((int)startPosX + stemPosX, (int)startPosY + 54);
            Point point2 = new Point((int)startPosX + Math.Abs(stemPosX - 10), (int)startPosY + 60);
            Point point3 = new Point((int)startPosX + Math.Abs(stemPosX - 180), (int)startPosY + 60);
            Point point4 = new Point((int)startPosX + Math.Abs(stemPosX - 190), (int)startPosY + 54);
            Point point5 = new Point((int)startPosX + Math.Abs(stemPosX - 80), (int)startPosY + 54);
            Point point6 = new Point((int)startPosX + Math.Abs(stemPosX - 66), (int)startPosY + 30);
            Point point7 = new Point((int)startPosX + Math.Abs(stemPosX - 54), (int)startPosY + 30);
            Point point8 = new Point((int)startPosX + Math.Abs(stemPosX - 48), (int)startPosY + 42);
            Point point9 = new Point((int)startPosX + Math.Abs(stemPosX - 40), (int)startPosY + 42);
            Point point10 = new Point((int)startPosX + Math.Abs(stemPosX - 34), (int)startPosY + 54);
            Point[] points = { point1, point2, point3, point4, point5, point6, point6, point7, point8, point9, point10 };
            g.FillPolygon(brush, points);
            Pen pen = new Pen(MainColor);
            g.DrawLine(pen, (int)startPosX + Math.Abs(stemPosX - 60), (int)startPosY + 30,
                (int)startPosX + Math.Abs(stemPosX - 60), (int)startPosY);
        }

        private void DrawCannon(Graphics g, int stemPosX)
        {
            Brush brush = new SolidBrush(MainColor);
            Point point1 = new Point((int)startPosX + Math.Abs(stemPosX - 78), (int)startPosY + 50);
            Point point2 = new Point((int)startPosX + Math.Abs(stemPosX - 230), (int)startPosY + 46);
            Point point3 = new Point((int)startPosX + Math.Abs(stemPosX - 230), (int)startPosY + 44);
            Point point4 = new Point((int)startPosX + Math.Abs(stemPosX - 74), (int)startPosY + 44);
            Point[] points = { point1, point2, point3, point4 };
            g.FillPolygon(brush, points);
        }

        public override string ToString()
        {
            return Index + "/" + MaxSpeed + "/" + Weight + "/" + MainColor.Name;
        }

        public int CompareTo(Warship other)
        {
            if (other == null)
                return 1;
            if (MaxSpeed != other.MaxSpeed)
                return MaxSpeed.CompareTo(other.MaxSpeed);
            else if (Weight != other.Weight)
                return Weight.CompareTo(other.Weight);
            else if (MainColor != other.MainColor)
                return MainColor.Name.CompareTo(other.MainColor.Name);
            return 0;
        }

        public bool Equals(Warship other)
        {
            if (other == null
                || GetType().Name != other.GetType().Name
                || MaxSpeed != other.MaxSpeed
                || Weight != other.Weight
                || MainColor != other.MainColor)
                return false;
            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Warship)) return false;
            else return base.Equals(obj as Warship);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
