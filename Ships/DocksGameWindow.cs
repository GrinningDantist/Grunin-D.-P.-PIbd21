using NLog;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ships
{
    public partial class DocksGameWindow : Form
    {
        private MultilevelDocks levels;

        private WarshipSelectionMenu menu;

        private const int numberOfLevels = 5;

        private Logger logger;

        public DocksGameWindow()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            levels = new MultilevelDocks(numberOfLevels, drawingArea.Width,
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
            levels[index].Draw(g);
            drawingArea.Image = bmp;
        }

        private void btnSelectShip_Click(object sender, EventArgs e)
        {
            int levelIndex = levelList.SelectedIndex;
            if (levelIndex == -1)
            {
                MessageBox.Show("Уровень не выбран", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int shipIndex = levels[levelIndex].TakenSpacesNumber;
            menu = new WarshipSelectionMenu(shipIndex);
            menu.AddEvent(AddShip);
            menu.gameWindow = this;
            menu.Show();
            this.Enabled = false;
        }

        private void AddShip(ITransport ship)
        {
            try
            {
                int space = levels[levelList.SelectedIndex] + ship;
                logger.Info("Добавлен корабль " + ship.ToString()
                    + " на место " + space);
                Draw();
            }
            catch (DocksOverflowException ex)
            {
                MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (ShipAlreadyExistsException ex)
            {
                MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnPickUp_Click(object sender, EventArgs e)
        {
            int levelIndex = levelList.SelectedIndex;
            if (levelIndex == -1 || spaceIndexField.Text == "") return;
            try
            {
                int shipIndex = int.Parse(spaceIndexField.Text);
                ITransport ship = levels[levelIndex] - shipIndex;
                Bitmap bmp = new Bitmap(warshipPicture.Width, warshipPicture.Height);
                Graphics g = Graphics.FromImage(bmp);
                ship.SetPosition(5, 5, warshipPicture.Width, warshipPicture.Height);
                ship.DrawTransport(g);
                warshipPicture.Image = bmp;
                logger.Info("Изъят корабль " + ship.ToString() + " с места "
                    + spaceIndexField.Text);
                Draw();
            }
            catch (ShipNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void levelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    levels.SaveData(saveFileDialog.FileName);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при сохранении",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    levels.LoadData(openFileDialog.FileName);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    Draw();
                }
                catch (SpaceTakenException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Неверный формат данных. Файл повреждён или не является файлом сохранения",
                        "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            levels.Sort();
            logger.Info("Сортировка уровней");
            Draw();
        }
    }
}
