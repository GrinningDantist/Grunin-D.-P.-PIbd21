using System.Drawing;
using System.Windows.Forms;

namespace Ships
{
    public partial class WarshipSelectionMenu : Form
    {
        public DocksGameWindow gameWindow;

        private ITransport ship = null;

        public event ShipDel eventAddShip;

        private bool btnMainColorPressed = false;
        private bool btnFlagColorPressed = false;

        public WarshipSelectionMenu()
        {
            InitializeComponent();
            this.btnCancel.Click += (object sender, System.EventArgs e) => Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            gameWindow.Enabled = true;
        }

        private void DrawShip()
        {
            if (ship == null) return;
            Bitmap bmp = new Bitmap(warshipPicture.Width, warshipPicture.Height);
            Graphics g = Graphics.FromImage(bmp);
            ship.SetPosition(5, 5, warshipPicture.Width, warshipPicture.Height);
            ship.DrawTransport(g);
            warshipPicture.Image = bmp;
        }

        private void lblWarship_MouseDown(object sender, MouseEventArgs e)
        {
            lblWarship.DoDragDrop(lblWarship.Text, DragDropEffects.Move
                | DragDropEffects.Copy);
        }

        private void lblBattleship_MouseDown(object sender, MouseEventArgs e)
        {
            lblBattleship.DoDragDrop(lblBattleship.Text, DragDropEffects.Move
                | DragDropEffects.Copy);
        }

        private void color_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void picturePanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)
                || e.Data.GetDataPresent(typeof(Color))
                && (btnMainColorPressed || btnFlagColorPressed
                && (ship is Battleship)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void picturePanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                switch (e.Data.GetData(DataFormats.Text).ToString())
                {
                    case "ВОЕННЫЙ КОРАБЛЬ":
                        ship = new Warship(100, 1000, Color.Gray);
                        break;
                    case "ЛИНКОР":
                        ship = new Battleship(100, 1000, Color.Gray,
                    Color.Red, true);
                        break;
                }
            }
            else if (e.Data.GetDataPresent(typeof(Color))
                && ship != null)
            {
                if (btnMainColorPressed)
                    ship.Repaint((Color)e.Data.GetData(typeof(Color)));
                else if (btnFlagColorPressed && ship is Battleship)
                {
                    (ship as Battleship).ChangeFlagColor(
                        (Color)e.Data.GetData(typeof(Color)));
                }
            }
            DrawShip();
        }

        private void btnMainColor_Click(object sender, System.EventArgs e)
        {
            btnFlagColor.BackColor = Color.White;
            btnFlagColor.ForeColor = Color.Black;
            btnFlagColorPressed = false;
            btnMainColor.BackColor = Color.Purple;
            btnMainColor.ForeColor = Color.Cyan;
            btnMainColorPressed = true;
        }

        private void btnFlagColor_Click(object sender, System.EventArgs e)
        {
            btnMainColor.BackColor = Color.White;
            btnMainColor.ForeColor = Color.Black;
            btnMainColorPressed = false;
            btnFlagColor.BackColor = Color.Purple;
            btnFlagColor.ForeColor = Color.Cyan;
            btnFlagColorPressed = true;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (ship == null)
            {
                MessageBox.Show("Вы не выбрали корабль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            eventAddShip.Invoke(ship);
            Close();
        }

        public void AddEvent(ShipDel e)
        {
            if (eventAddShip == null) eventAddShip = e;
            else eventAddShip += e;
        }
    }
}
