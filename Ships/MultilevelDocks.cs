using System.Collections.Generic;

namespace Ships
{
    class MultilevelDocks
    {
        List<Docks<ITransport>> levels;

        private const int levelCapacity = 15;

        public MultilevelDocks(int NumberOfLevels, int pictureWidth, int pictureHeight)
        {
            levels = new List<Docks<ITransport>>();
            for (int i = 0; i < NumberOfLevels; i++)
            {
                levels.Add(new Docks<ITransport>(levelCapacity, pictureWidth,
                    pictureHeight));
            }
        }

        public Docks<ITransport> this[int index]
        {
            get
            {
                if (index >= 0 && index < levels.Count)
                    return levels[index];
                return null;
            }
        }
    }
}
