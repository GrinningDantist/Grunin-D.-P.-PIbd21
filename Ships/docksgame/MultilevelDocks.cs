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

        public void SaveData(string filePath)
        {
            using (StreamWriter saveFile = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                saveFile.Write("number_of_levels " + levels.Count);
                foreach (var level in levels)
                {
                    if (level.IsEmpty) continue;
                    saveFile.Write("{0}{0}level {1}", Environment.NewLine, level);
                    foreach (ITransport ship in level)
                    {
                        if (ship == null) continue;
                        string shipType = ship.GetType().Name.ToLower();
                        saveFile.Write(Environment.NewLine + shipType + ' ' + ship);
                    }
                }
            }
        }

        public void LoadData(string filePath)
        {
            if (!File.Exists(filePath)) throw new FileNotFoundException();
            string[] dataStrings = CopyDataToStringArray(filePath);
            if (dataStrings.Length == 0 || !CheckDataCorrectness(dataStrings))
                throw new Exception("Неверный формат файла");
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

        private bool CheckDataCorrectness(string[] dataStrings)
        {
            string[] data = dataStrings[0].Split(' ');
            if (!CheckLevelsNumberCorrectness(data)) return false;
            bool levelsMarked = false;
            for (int i = 1; i < dataStrings.Length; i++)
            {
                data = dataStrings[i].Split(' ');
                if (data.Length != 2) return false;
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
            if (data[0] != "number_of_levels"
                || !int.TryParse(data[1], out int numberOfLevels))
                return false;
            return true;
        }

        private bool CheckLevelDataCorrectness(string[] data)
        {
            if (!int.TryParse(data[1], out int result))
                return false;
            return true;
        }

        private bool CheckShipDataCorrectness(string[] data)
        {
            string[] shipParameters = data[1].Split('/');
            if (shipParameters.Length < 4
                || !int.TryParse(shipParameters[0], out int index)
                || !int.TryParse(shipParameters[1], out int maxSpeed)
                || !float.TryParse(shipParameters[2], out float weight)
                || data[0] == "battleship" && (shipParameters.Length != 7
                || !int.TryParse(shipParameters[4], out int numberOfCannons)
                || !bool.TryParse(shipParameters[5], out bool flag)))
                return false;
            return true;
        }


        private void ReplaceData(string[] dataStrings)
        {
            int numberOfLevels = int.Parse(dataStrings[0].Split(' ')[1]);
            levels.Clear();
            CreateLevels(numberOfLevels, pictureWidth, pictureHeight);
            int currentLevel = 0;
            for (int i = 1; i < dataStrings.Length; i++)
            {
                string[] data = dataStrings[i].Split(' ');
                if (data[0] == "level")
                {
                    currentLevel = int.Parse(data[1]);
                    continue;
                }
                ITransport ship = null;
                if (data[0] == "warship")
                    ship = new Warship(data[1]);
                else if (data[0] == "battleship")
                    ship = new Battleship(data[1]);
                int shipIndex = int.Parse(data[2]);
                levels[currentLevel][shipIndex] = ship;
            }
        }

        public void Sort()
        {
            levels.Sort();
        }
    }
}
