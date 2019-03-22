using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ships
{
    public partial class DocksGameWindow : Form
    {
        private MultilevelDocks docks;

        private WarshipSelectionMenu menu;

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

        private void btnSelectShip_Click(object sender, EventArgs e)
        {
            if (levelList.SelectedIndex == -1)
            {
                MessageBox.Show("Уровень не выбран", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            menu = new WarshipSelectionMenu();
            menu.AddEvent(AddShip);
            menu.gameWindow = this;
            menu.Show();
            this.Enabled = false;
        }

        private void AddShip(ITransport ship)
        {
            int space = docks[levelList.SelectedIndex] + ship;
            if (space > -1) Draw();
            else MessageBox.Show("Мест нет", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
