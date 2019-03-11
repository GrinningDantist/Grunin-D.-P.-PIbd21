using System.Collections.Generic;
using System.Drawing;

namespace Ships
{
    class Docks<T> where T : class, ITransport
    {
        private const int spaceWidth = 350;
        private const int spaceHeight = 90;

        private Dictionary<int, T> spaces;

        private int n;

        public bool IsEmpty { get { return spaces.Count == 0; } }

        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }

        public Docks(int numberOfSpaces, int pictureWidth, int pictureHeight)
        {
            spaces = new Dictionary<int, T>();
            n = numberOfSpaces;
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
        }

        public static int operator +(Docks<T> docks, T ship)
        {
            if (docks.spaces.Count == docks.n) return -1;
            for (int i = 0; i < docks.n; i++)
            {
                if (docks.CheckSpaceAvailabiliy(i))
                {
                    docks.spaces.Add(i, ship);
                    docks.spaces[i].SetPosition(5 + i / 5 * spaceWidth + 5,
                        i % 5 * spaceHeight + 15, docks.PictureWidth, docks.PictureHeight);
                    return i;
                }
            }
            return -1;
        }

        public static T operator -(Docks<T> docks, int index)
        {
            if (index < 0 || index >= docks.n)
                return null;
            if (!docks.CheckSpaceAvailabiliy(index))
            {
                T ship = docks.spaces[index];
                docks.spaces.Remove(index);
                return ship;
            }
            return null;
        }

        private bool CheckSpaceAvailabiliy(int index)
        {
            return !spaces.ContainsKey(index);
        }

        public void Draw(Graphics g)
        {
            DrawBorders(g);
            foreach (T space in spaces.Values)
                space.DrawTransport(g);
        }

        public void DrawBorders(Graphics g)
        {
            Pen pen = new Pen(Color.White, 3);
            g.DrawRectangle(pen, 0, 0, (n / 5) * spaceWidth, 480);
            for (int i = 0; i < n / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * spaceWidth, j * spaceHeight,
                    i * spaceWidth + 250, j * spaceHeight);
                }
                g.DrawLine(pen, i * spaceWidth, 0, i * spaceWidth, 450);
            }
        }

        public T this[int i]
        {
            get
            {
                if (spaces.ContainsKey(i))
                    return spaces[i];
                else return null;
            }
            set
            {
                if (CheckSpaceAvailabiliy(i))
                {
                    spaces.Add(i, value);
                    spaces[i].SetPosition(5 + i / 5 * spaceWidth + 5,
                        i % 5 * spaceHeight + 15, PictureWidth, PictureHeight);
                }
            }
        }
    }
}
