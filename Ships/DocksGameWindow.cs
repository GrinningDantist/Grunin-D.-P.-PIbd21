using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ships
{
    public partial class DocksGameWindow : Form
    {
        private MultilevelDocks docks;

        private const int numberOfLevels = 5;

        public DocksGameWindow()
        {
            InitializeComponent();
            docks = new MultilevelDocks(numberOfLevels, drawingArea.Width,
                drawingArea.Height);
            for (int i = 1; i <= numberOfLevels; i++)
                levelList.Items.Add("Уровень" + i);
            levelList.SelectedIndex = 0;
        }

        private void Draw()
        {
            int index = levelList.SelectedIndex;
            if (index == -1) return;
            Bitmap bmp = new Bitmap(drawingArea.Width, drawingArea.Height);
            Graphics g = Graphics.FromImage(bmp);
            docks[index].Draw(g);
            drawingArea.Image = bmp;
        }

        private void btnMoorWarship_Click(object sender, EventArgs e)
        {
            int index = levelList.SelectedIndex;
            if (index == -1) return;
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;
            ITransport ship = new Warship(100, 1000, dialog.Color);
            int place = docks[index] + ship;
            if (place == -1)
            {
                MessageBox.Show("Нет свободных мест", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Draw();
        }

        private void btnMoorBattleship_Click(object sender, EventArgs e)
        {
            int index = levelList.SelectedIndex;
            if (index == -1) return;
            ColorDialog mainColorDialog = new ColorDialog();
            if (mainColorDialog.ShowDialog() == DialogResult.Cancel) return;
            ColorDialog flagColorDialog = new ColorDialog();
            if (flagColorDialog.ShowDialog() == DialogResult.Cancel) return;
            ITransport ship = new Battleship(100, 1000, mainColorDialog.Color,
                flagColorDialog.Color, true);
            int place = docks[index] + ship;
            if (place == -1)
            {
                MessageBox.Show("Нет свободных мест", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Draw();
        }

        private void btnPickUp_Click(object sender, EventArgs e)
        {
            int levelIndex = levelList.SelectedIndex;
            if (levelIndex == -1) return;
            if (spaceIndexField.Text == "") return;
            int shipIndex = int.Parse(spaceIndexField.Text);
            ITransport ship = docks[levelIndex] - shipIndex;
            if (ship == null) return;
            Bitmap bmp = new Bitmap(warshipPicture.Width, warshipPicture.Height);
            Graphics g = Graphics.FromImage(bmp);
            ship.SetPosition(5, 5, warshipPicture.Width, warshipPicture.Height);
            ship.DrawTransport(g);
            warshipPicture.Image = bmp;
            Draw();
        }

        private void levelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
