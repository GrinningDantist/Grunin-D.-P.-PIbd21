using System;
using System.Drawing;

namespace Ships
{
    class Battleship : Warship, IComparable<Battleship>, IEquatable<Battleship>
    {
        public Color FlagColor { get; private set; }

        private int numberOfCannons;

        public int NumberOfCannons
        {
            get { return numberOfCannons; }
            private set { if (value > 0 && value < 4) numberOfCannons = value; }
        }

        public bool Flag { get; private set; }

        public Battleship(int index, int maxSpeed, float weight, Color mainColor,
            Color flagColor, bool flag) : base(index, maxSpeed, weight, mainColor)
        {
            FlagColor = flagColor;
            Flag = flag;
            NumberOfCannons = new Random().Next(1, 4);
        }

        public Battleship(string data, out bool success) : base(data, out success)
        {
            string[] parameters = data.Split('/');
            if (parameters.Length != 7) { success = false; return; }
            Index = int.Parse(parameters[0]);
            MaxSpeed = int.Parse(parameters[1]);
            Weight = int.Parse(parameters[2]);
            MainColor = Color.FromName(parameters[3]);
            numberOfCannons = int.Parse(parameters[4]);
            Flag = bool.Parse(parameters[5]);
            FlagColor = Color.FromName(parameters[6]);
            success = true;
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
            DrawCannons(g, stemPosX);
            DrawFlag(g, stemPosX);
        }

        private void DrawFlag(Graphics g, int stemPosX)
        {
            Brush brush = new SolidBrush(FlagColor);
            if (Flag)
            {
                g.FillRectangle(brush, startPosX + Math.Abs(stemPosX - 60),
                    (int)startPosY, 10, 6);
            }
        }

        private void DrawCannons(Graphics g, int stemPosX)
        {
            Pen pen = new Pen(MainColor);
            int x1 = (int)startPosX + Math.Abs(stemPosX - 80);
            int x2 = (int)startPosX + Math.Abs(stemPosX - 100);
            int y1 = (int)startPosY + 54;
            int y2 = (int)startPosY + 44;
            for (int i = 0; i < NumberOfCannons; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    g.DrawLine(pen, x1, y1, x2, y2);
                    if (dirX == Direction.Left) { x1 -= 8; x2 -= 8; }
                    else { x1 += 8; x2 += 8; }
                }
                if (dirX == Direction.Left) { x1 -= 8; x2 -= 8; }
                else { x1 += 8; x2 += 8; }
            }
        }

        public void ChangeFlagColor(Color color)
        {
            FlagColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + "/" + NumberOfCannons + "/"
                + Flag + "/" + FlagColor.Name;
        }

        public int CompareTo(Battleship other)
        {
            int position = (this as Warship).CompareTo(other as Warship);
            if (position != 0) return position;
            if (NumberOfCannons != other.NumberOfCannons)
                return NumberOfCannons.CompareTo(other.NumberOfCannons);
            if (Flag != other.Flag)
                return Flag.CompareTo(other.Flag);
            if (FlagColor != other.FlagColor)
                return FlagColor.Name.CompareTo(other.FlagColor.Name);
            return 0;
        }

        public bool Equals(Battleship other)
        {
            if (!(this as Warship).Equals(other as Warship)
                || GetType().Name != other.GetType().Name
                || NumberOfCannons != other.NumberOfCannons
                || Flag != other.Flag
                || FlagColor != other.FlagColor)
                return false;
            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Battleship)) return false;
            else return base.Equals(obj as Battleship);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
