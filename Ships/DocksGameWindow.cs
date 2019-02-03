﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ships
{
    public partial class DocksGameWindow : Form
    {
        private Docks<ITransport> docks;

        public DocksGameWindow()
        {
            InitializeComponent();
            docks = new Docks<ITransport>(10, drawingArea.Width, drawingArea.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(drawingArea.Width, drawingArea.Height);
            Graphics g = Graphics.FromImage(bmp);
            docks.Draw(g);
            drawingArea.Image = bmp;
        }

        private void btnMoorWarship_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;
            ITransport ship = new Warship(100, 1000, dialog.Color);
            int place = docks + ship;
            Draw();
        }

        private void btnMoorBattleship_Click(object sender, EventArgs e)
        {
            ColorDialog mainColorDialog = new ColorDialog();
            if (mainColorDialog.ShowDialog() == DialogResult.Cancel) return;
            ColorDialog flagColorDialog = new ColorDialog();
            if (flagColorDialog.ShowDialog() == DialogResult.Cancel) return;
            ITransport ship = new Battleship(100, 1000, mainColorDialog.Color,
                flagColorDialog.Color, true);
            int place = docks + ship;
            Draw();
        }

        private void btnPickUp_Click(object sender, EventArgs e)
        {
            if (spaceIndexField.Text == "") return;
            int index = int.Parse(spaceIndexField.Text);
            ITransport ship = docks - index;
            if (ship == null) return;
            Bitmap bmp = new Bitmap(warshipPicture.Width, warshipPicture.Height);
            Graphics g = Graphics.FromImage(bmp);
            ship.SetPosition(5, 5, warshipPicture.Width, warshipPicture.Height);
            ship.DrawTransport(g);
            warshipPicture.Image = bmp;
            Draw();
        }
    }
}
