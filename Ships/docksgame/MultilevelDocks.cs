using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Ships
{
    class MultilevelDocks
    {
        List<Docks<ITransport>> levels;

        private const int levelCapacity = 10;

        private int pictureWidth;
        private int pictureHeight;

        public MultilevelDocks(int numberOfLevels, int pictureWidth, int pictureHeight)
        {
            levels = CreateLevels(numberOfLevels, pictureWidth, pictureHeight);
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        private List<Docks<ITransport>> CreateLevels(int numberOfLevels, int pictureWidth, int pictureHeight)
        {
            List<Docks<ITransport>> newLevels = new List<Docks<ITransport>>();
            for (int i = 0; i < numberOfLevels; i++)
            {
                newLevels.Add(new Docks<ITransport>(levelCapacity, pictureWidth,
                    pictureHeight));
            }
            return newLevels;
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

        public void SaveData(string filePath)
        {
            using (StreamWriter saveFile = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                saveFile.Write("number_of_levels " + levels.Count);
                for (int i = 0; i < levels.Count; i++)
                {
                    try
                    {
                        if (levels[i].IsEmpty) continue;
                        saveFile.Write("{0}{0}level {1}", Environment.NewLine, levels[i]);
                        for (int j = 0; j < levelCapacity; j++)
                        {
                            var ship = levels[i][j];
                            if (ship == null) continue;
                            string shipType = ship.GetType().Name.ToLower();
                            saveFile.Write(Environment.NewLine + shipType + " " + ship + " " + j);
                        }
                    }
                    finally { }
                }
            }
        }

        public void LoadData(string filePath)
        {
            if (!File.Exists(filePath)) throw new FileNotFoundException();
            string[] dataStrings = CopyDataToStringArray(filePath);
            ReplaceData(dataStrings);
        }

        private string[] CopyDataToStringArray(string filePath)
        {
            string unclutteredFileText;
            using (StreamReader saveFile = new StreamReader(filePath))
            {
                unclutteredFileText = Regex.Replace(saveFile.ReadToEnd(),
                    @"(^\s*\#.*|\s*$\s+)+", Environment.NewLine,
                    RegexOptions.Multiline).Trim();
            }
            string[] dataStrings = unclutteredFileText.Split(
                new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            return dataStrings;
        }

        private void ReplaceData(string[] dataStrings)
        {
            string[] numberOfLevelsSetting = dataStrings[0].Split(' ');
            if (numberOfLevelsSetting.Length != 2 || numberOfLevelsSetting[0] != "number_of_levels")
                throw new FormatException();
            int numberOfLevels = int.Parse(numberOfLevelsSetting[1]);
            List<Docks<ITransport>> loadedLevels = CreateLevels(numberOfLevels, pictureWidth, pictureHeight);
            int levelIndex = 0;
            for (int i = 1; i < dataStrings.Length; i++)
            {
                string[] data = dataStrings[i].Split(' ');
                Vehicle ship = null;
                if (data.Length == 2 && data[0] == "level")
                {
                    levelIndex = int.Parse(data[1]) - 1;
                    continue;
                }
                else if (data.Length == 3)
                {
                    if (data[0] == "warship")
                        ship = new Warship(data[1]);
                    else if (data[0] == "battleship")
                        ship = new Battleship(data[1]);
                }
                else throw new FormatException();
                int shipIndex = int.Parse(data[2]);
                loadedLevels[levelIndex][shipIndex] = ship;
            }
            levels = loadedLevels;
        }
    }
}
