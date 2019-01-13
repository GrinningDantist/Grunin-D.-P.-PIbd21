using System.Drawing;

namespace Ships
{
    class Docks<T> where T : class, ITransport
    {
        private const int spaceWidth = 350;
        private const int spaceHeight = 90;

        private T[] spaces;

        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }

        public Docks(int numberOfSpaces, int pictureWidth, int pictureHeight)
        {
            spaces = new T[numberOfSpaces];
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
            for (int i = 0; i < spaces.Length; i++)
                spaces[i] = null;
        }

        public static int operator +(Docks<T> docks, T ship)
        {
            for (int i = 0; i < docks.spaces.Length; i++)
            {
                if (docks.CheckSpaceAvailabiliy(i))
                {
                    docks.spaces[i] = ship;
                    docks.spaces[i].SetPosition(5 + i / 5 * spaceWidth + 5,
                        i % 5 * spaceHeight + 15, docks.PictureWidth, docks.PictureHeight);
                    return i;
                }
            }
            return -1;
        }

        public static T operator -(Docks<T> docks, int index)
        {
            if (index < 0 || index > docks.spaces.Length - 1)
                return null;
            if (!docks.CheckSpaceAvailabiliy(index))
            {
                T ship = docks.spaces[index];
                docks.spaces[index] = null;
                return ship;
            }
            return null;
        }

        private bool CheckSpaceAvailabiliy(int index)
        {
            return spaces[index] == null;
        }

        public void Draw(Graphics g)
        {
            DrawBorders(g);
            for (int i = 0; i < spaces.Length; i++)
            {
                if (!CheckSpaceAvailabiliy(i))
                    spaces[i].DrawTransport(g);
            }
        }

        public void DrawBorders(Graphics g)
        {
            Pen pen = new Pen(Color.White, 3);
            g.DrawRectangle(pen, 0, 0, (spaces.Length / 5) * spaceWidth, 480);
            for (int i = 0; i < spaces.Length / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * spaceWidth, j * spaceHeight,
                    i * spaceWidth + 250, j * spaceHeight);
                }
                g.DrawLine(pen, i * spaceWidth, 0, i * spaceWidth, 450);
            }
        }

    }
}
