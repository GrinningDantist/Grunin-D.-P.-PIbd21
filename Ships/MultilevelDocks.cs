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
            levels = new List<Docks<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            CreateLevels(numberOfLevels, pictureWidth, pictureHeight);
        }

        private void CreateLevels(int numberOfLevels, int pictureWidth, int pictureHeight)
        {
            for (int i = 0; i < numberOfLevels; i++)
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

        public bool SaveData(string filePath)
        {
            using (StreamWriter saveFile = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                saveFile.Write("number_of_levels " + levels.Count);
                for (int i = 0; i < levels.Count; i++)
                {
                    if (levels[i].IsEmpty) continue;
                    saveFile.Write("{0}{0}level {1}", Environment.NewLine, i + 1);
                    for (int j = 0; j < levelCapacity; j++)
                    {
                        var ship = levels[i][j];
                        if (ship == null) continue;
                        string shipType = ship.GetType().Name.ToLower();
                        saveFile.Write(Environment.NewLine + shipType + " " + ship + " " + j);
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filePath)
        {
            if (!File.Exists(filePath)) return false;
            string[] dataStrings = CopyDataToStringArray(filePath);
            if (dataStrings.Length == 0 || !CheckDataCorrectness(dataStrings))
                return false;
            ReplaceData(dataStrings);
            return true;
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

        private bool CheckDataCorrectness(string[] dataStrings)
        {
            string[] data = dataStrings[0].Split(' ');
            if (!CheckLevelsNumberCorrectness(data)) return false;
            bool levelsMarked = false;
            for (int i = 1; i < dataStrings.Length; i++)
            {
                data = dataStrings[i].Split(' ');
                if (data[0] == "level")
                {
                    if (!CheckLevelDataCorrectness(data)) return false;
                    else levelsMarked = true;
                }
                else if (levelsMarked && (data[0] == "warship" || data[0] == "battleship"))
                {
                    if (!CheckShipDataCorrectness(data)) return false;
                }
                else return false;
            }
            return true;
        }

        private bool CheckLevelsNumberCorrectness(string[] data)
        {
            if (data.Length != 2 || data[0] != "number_of_levels"
                || !int.TryParse(data[1], out int numberOfLevels)
                || numberOfLevels <= 0)
                return false;
            return true;
        }

        private bool CheckLevelDataCorrectness(string[] data)
        {
            if (data.Length != 2 || !int.TryParse(data[1], out int result))
                return false;
            return true;
        }

        private bool CheckShipDataCorrectness(string[] data)
        {
            if (data.Length != 3) return false;
            string[] shipParameters = data[1].Split('/');
            if (shipParameters.Length < 3
                        || !int.TryParse(shipParameters[0], out int maxSpeed)
                        || !float.TryParse(shipParameters[1], out float weight)
                        || data[0] == "battleship" && (shipParameters.Length != 6
                        || !int.TryParse(shipParameters[3], out int numberOfCannons)
                        || !bool.TryParse(shipParameters[4], out bool flag)))
                return false;
            if (!int.TryParse(data[2], out int index))
                return false;
            return true;
        }


        private void ReplaceData(string[] dataStrings)
        {
            int numberOfLevels = int.Parse(dataStrings[0].Split(' ')[1]);
            levels.Clear();
            CreateLevels(numberOfLevels, pictureWidth, pictureHeight);
            int levelIndex = 0;
            for (int i = 1; i < dataStrings.Length; i++)
            {
                string[] data = dataStrings[i].Split(' ');
                if (data[0] == "level")
                {
                    levelIndex = int.Parse(data[1]) - 1;
                    continue;
                }
                ITransport ship = null;
                if (data[0] == "warship")
                    ship = new Warship(data[1]);
                else if (data[0] == "battleship")
                    ship = new Battleship(data[1]);
                int shipIndex = int.Parse(data[2]);
                levels[levelIndex][shipIndex] = ship;
            }
        }
    }
}
