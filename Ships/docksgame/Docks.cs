using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace Ships
{
    class Docks<T> : IEnumerator<T>, IEnumerable<T>, IComparable<Docks<T>>
        where T : class, ITransport
    {
        private const int spaceWidth = 350;
        private const int spaceHeight = 90;

        private Dictionary<int, T> spaces;

        private int n;
        private int currentIndex;

        public T Current { get { return spaces[GetKey]; } }

        object IEnumerator.Current { get { return Current; } }

        public int GetKey { get { return new List<int>(spaces.Keys)[currentIndex]; } }

        public bool IsEmpty { get { return spaces.Count == 0; } }

        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }

        public Docks(int numberOfSpaces, int pictureWidth, int pictureHeight)
        {
            spaces = new Dictionary<int, T>();
            n = numberOfSpaces;
            currentIndex = -1;
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
        }

        public static int operator +(Docks<T> docks, T ship)
        {
            if (docks.spaces.Count == docks.n)
                throw new DocksOverflowException();
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
                throw new IndexOutOfRangeException(
                    "Места с данным индексом не существует");
            if (!docks.CheckSpaceAvailabiliy(index))
            {
                T ship = docks.spaces[index];
                docks.spaces.Remove(index);
                return ship;
            }
            throw new ShipNotFoundException(index);
        }

        private bool CheckSpaceAvailabiliy(int index)
        {
            return !spaces.ContainsKey(index);
        }

        public void Draw(Graphics g)
        {
            DrawBorders(g);
            foreach (T ship in spaces.Values)
                ship.DrawTransport(g);
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

        public void Dispose()
        {
            spaces.Clear();
        }

        public bool MoveNext()
        {
            if (currentIndex + 1 >= spaces.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(Docks<T> other)
        {
            if (spaces.Count < other.spaces.Count) return -1;
            else if (spaces.Count > other.spaces.Count) return 1;
            else if (spaces.Count > 0)
            {
                var thisKeys = new List<int>(spaces.Keys);
                var otherKeys = new List<int>(other.spaces.Keys);
                for (int i = 0; i < spaces.Count; i++)
                {
                    if (spaces[thisKeys[i]] is Warship)
                    {
                        if (other.spaces[thisKeys[i]] is Battleship) return -1;
                        else if (other.spaces[thisKeys[i]] is Warship)
                        {
                            return (spaces[thisKeys[i]] is Warship).CompareTo(other.spaces[thisKeys[i]]
                                is Warship);
                        }
                    }
                    else if (spaces[thisKeys[i]] is Battleship)
                    {
                        if (other.spaces[thisKeys[i]] is Warship)
                            return 1;
                        else if (other.spaces[thisKeys[i]] is Battleship)
                        {
                            return (spaces[thisKeys[i]] is Battleship).CompareTo(other.spaces[thisKeys[i]]
                                is Battleship);
                        }
                    }
                }
            }
            return 0;
        }

        public T this[int i]
        {
            get
            {
                if (spaces.ContainsKey(i))
                    return spaces[i];
                else throw new ShipNotFoundException(i);
            }
            set
            {
                if (CheckSpaceAvailabiliy(i))
                {
                    spaces.Add(i, value);
                    spaces[i].SetPosition(5 + i / 5 * spaceWidth + 5,
                        i % 5 * spaceHeight + 15, PictureWidth, PictureHeight);
                }
                else throw new SpaceTakenException(i);
            }
        }
    }
}
