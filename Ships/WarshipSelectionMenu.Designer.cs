namespace Ships
{
    partial class WarshipSelectionMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.typeButtons = new System.Windows.Forms.GroupBox();
            this.lblCruiser = new System.Windows.Forms.Label();
            this.lblWarship = new System.Windows.Forms.Label();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.warshipPicture = new System.Windows.Forms.PictureBox();
            this.colorPalette = new System.Windows.Forms.GroupBox();
            this.btnFlagColor = new System.Windows.Forms.Button();
            this.btnMainColor = new System.Windows.Forms.Button();
            this.colorBlue = new System.Windows.Forms.Panel();
            this.colorWhite = new System.Windows.Forms.Panel();
            this.colorYellow = new System.Windows.Forms.Panel();
            this.colorOrange = new System.Windows.Forms.Panel();
            this.colorGreen = new System.Windows.Forms.Panel();
            this.colorBlack = new System.Windows.Forms.Panel();
            this.colorRed = new System.Windows.Forms.Panel();
            this.colorGray = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.typeButtons.SuspendLayout();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warshipPicture)).BeginInit();
            this.colorPalette.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeButtons
            // 
            this.typeButtons.BackColor = System.Drawing.Color.Transparent;
            this.typeButtons.Controls.Add(this.lblCruiser);
            this.typeButtons.Controls.Add(this.lblWarship);
            this.typeButtons.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeButtons.ForeColor = System.Drawing.Color.White;
            this.typeButtons.Location = new System.Drawing.Point(12, 12);
            this.typeButtons.Name = "typeButtons";
            this.typeButtons.Size = new System.Drawing.Size(181, 124);
            this.typeButtons.TabIndex = 8;
            this.typeButtons.TabStop = false;
            this.typeButtons.Text = "ТИП";
            // 
            // lblCruiser
            // 
            this.lblCruiser.BackColor = System.Drawing.Color.White;
            this.lblCruiser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCruiser.ForeColor = System.Drawing.Color.Black;
            this.lblCruiser.Location = new System.Drawing.Point(6, 71);
            this.lblCruiser.Name = "lblCruiser";
            this.lblCruiser.Size = new System.Drawing.Size(170, 38);
            this.lblCruiser.TabIndex = 1;
            this.lblCruiser.Text = "КРЕЙСЕР";
            this.lblCruiser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCruiser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCruiser_MouseDown);
            // 
            // lblWarship
            // 
            this.lblWarship.BackColor = System.Drawing.Color.White;
            this.lblWarship.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWarship.ForeColor = System.Drawing.Color.Black;
            this.lblWarship.Location = new System.Drawing.Point(6, 23);
            this.lblWarship.Name = "lblWarship";
            this.lblWarship.Size = new System.Drawing.Size(170, 38);
            this.lblWarship.TabIndex = 0;
            this.lblWarship.Text = "ВОЕННЫЙ КОРАБЛЬ";
            this.lblWarship.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWarship.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblWarship_MouseDown);
            // 
            // picturePanel
            // 
            this.picturePanel.AllowDrop = true;
            this.picturePanel.BackColor = System.Drawing.Color.Transparent;
            this.picturePanel.Controls.Add(this.warshipPicture);
            this.picturePanel.Location = new System.Drawing.Point(199, 12);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(359, 124);
            this.picturePanel.TabIndex = 9;
            this.picturePanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.picturePanel_DragDrop);
            this.picturePanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.picturePanel_DragEnter);
            // 
            // warshipPicture
            // 
            this.warshipPicture.Location = new System.Drawing.Point(0, 0);
            this.warshipPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.warshipPicture.Name = "warshipPicture";
            this.warshipPicture.Size = new System.Drawing.Size(359, 124);
            this.warshipPicture.TabIndex = 4;
            this.warshipPicture.TabStop = false;
            // 
            // colorPalette
            // 
            this.colorPalette.BackColor = System.Drawing.Color.Transparent;
            this.colorPalette.Controls.Add(this.btnFlagColor);
            this.colorPalette.Controls.Add(this.btnMainColor);
            this.colorPalette.Controls.Add(this.colorBlue);
            this.colorPalette.Controls.Add(this.colorWhite);
            this.colorPalette.Controls.Add(this.colorYellow);
            this.colorPalette.Controls.Add(this.colorOrange);
            this.colorPalette.Controls.Add(this.colorGreen);
            this.colorPalette.Controls.Add(this.colorBlack);
            this.colorPalette.Controls.Add(this.colorRed);
            this.colorPalette.Controls.Add(this.colorGray);
            this.colorPalette.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorPalette.ForeColor = System.Drawing.Color.White;
            this.colorPalette.Location = new System.Drawing.Point(199, 144);
            this.colorPalette.Name = "colorPalette";
            this.colorPalette.Size = new System.Drawing.Size(358, 126);
            this.colorPalette.TabIndex = 10;
            this.colorPalette.TabStop = false;
            this.colorPalette.Text = "ЦВЕТА";
            // 
            // btnFlagColor
            // 
            this.btnFlagColor.BackColor = System.Drawing.Color.White;
            this.btnFlagColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlagColor.ForeColor = System.Drawing.Color.Black;
            this.btnFlagColor.Location = new System.Drawing.Point(182, 70);
            this.btnFlagColor.Name = "btnFlagColor";
            this.btnFlagColor.Size = new System.Drawing.Size(170, 38);
            this.btnFlagColor.TabIndex = 9;
            this.btnFlagColor.Text = "ДОПОЛНИТЕЛЬНЫЙ";
            this.btnFlagColor.UseVisualStyleBackColor = false;
            this.btnFlagColor.Click += new System.EventHandler(this.btnFlagColor_Click);
            // 
            // btnMainColor
            // 
            this.btnMainColor.BackColor = System.Drawing.Color.White;
            this.btnMainColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainColor.ForeColor = System.Drawing.Color.Black;
            this.btnMainColor.Location = new System.Drawing.Point(6, 70);
            this.btnMainColor.Name = "btnMainColor";
            this.btnMainColor.Size = new System.Drawing.Size(170, 38);
            this.btnMainColor.TabIndex = 8;
            this.btnMainColor.Text = "ОСНОВНОЙ";
            this.btnMainColor.UseVisualStyleBackColor = false;
            this.btnMainColor.Click += new System.EventHandler(this.btnMainColor_Click);
            // 
            // colorBlue
            // 
            this.colorBlue.BackColor = System.Drawing.Color.Blue;
            this.colorBlue.Location = new System.Drawing.Point(226, 26);
            this.colorBlue.Name = "colorBlue";
            this.colorBlue.Size = new System.Drawing.Size(38, 38);
            this.colorBlue.TabIndex = 7;
            this.colorBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.color_MouseDown);
            // 
            // colorWhite
            // 
            this.colorWhite.BackColor = System.Drawing.Color.White;
            this.colorWhite.Location = new System.Drawing.Point(182, 26);
            this.colorWhite.Name = "colorWhite";
            this.colorWhite.Size = new System.Drawing.Size(38, 38);
            this.colorWhite.TabIndex = 6;
            this.colorWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.color_MouseDown);
            // 
            // colorYellow
            // 
            this.colorYellow.BackColor = System.Drawing.Color.Yellow;
            this.colorYellow.Location = new System.Drawing.Point(270, 26);
            this.colorYellow.Name = "colorYellow";
            this.colorYellow.Size = new System.Drawing.Size(38, 38);
            this.colorYellow.TabIndex = 5;
            this.colorYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.color_MouseDown);
            // 
            // colorOrange
            // 
            this.colorOrange.BackColor = System.Drawing.Color.Orange;
            this.colorOrange.Location = new System.Drawing.Point(314, 26);
            this.colorOrange.Name = "colorOrange";
            this.colorOrange.Size = new System.Drawing.Size(38, 38);
            this.colorOrange.TabIndex = 4;
            this.colorOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.color_MouseDown);
            // 
            // colorGreen
            // 
            this.colorGreen.BackColor = System.Drawing.Color.Green;
            this.colorGreen.Location = new System.Drawing.Point(50, 26);
            this.colorGreen.Name = "colorGreen";
            this.colorGreen.Size = new System.Drawing.Size(38, 38);
            this.colorGreen.TabIndex = 3;
            this.colorGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.color_MouseDown);
            // 
            // colorBlack
            // 
            this.colorBlack.BackColor = System.Drawing.Color.Black;
            this.colorBlack.Location = new System.Drawing.Point(6, 26);
            this.colorBlack.Name = "colorBlack";
            this.colorBlack.Size = new System.Drawing.Size(38, 38);
            this.colorBlack.TabIndex = 2;
            this.colorBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.color_MouseDown);
            // 
            // colorRed
            // 
            this.colorRed.BackColor = System.Drawing.Color.Red;
            this.colorRed.Location = new System.Drawing.Point(94, 26);
            this.colorRed.Name = "colorRed";
            this.colorRed.Size = new System.Drawing.Size(38, 38);
            this.colorRed.TabIndex = 1;
            this.colorRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.color_MouseDown);
            // 
            // colorGray
            // 
            this.colorGray.BackColor = System.Drawing.Color.Gray;
            this.colorGray.Location = new System.Drawing.Point(138, 26);
            this.colorGray.Name = "colorGray";
            this.colorGray.Size = new System.Drawing.Size(38, 38);
            this.colorGray.TabIndex = 0;
            this.colorGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.color_MouseDown);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(18, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 38);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "ДОБАВИТЬ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(18, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 38);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "ОТМЕНА";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // WarshipSelectionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(568, 281);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.colorPalette);
            this.Controls.Add(this.picturePanel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.typeButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WarshipSelectionMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор корабля";
            this.typeButtons.ResumeLayout(false);
            this.picturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warshipPicture)).EndInit();
            this.colorPalette.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox typeButtons;
        private System.Windows.Forms.Label lblCruiser;
        private System.Windows.Forms.Label lblWarship;
        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.PictureBox warshipPicture;
        private System.Windows.Forms.GroupBox colorPalette;
        private System.Windows.Forms.Button btnFlagColor;
        private System.Windows.Forms.Button btnMainColor;
        private System.Windows.Forms.Panel colorBlue;
        private System.Windows.Forms.Panel colorWhite;
        private System.Windows.Forms.Panel colorYellow;
        private System.Windows.Forms.Panel colorOrange;
        private System.Windows.Forms.Panel colorGreen;
        private System.Windows.Forms.Panel colorBlack;
        private System.Windows.Forms.Panel colorRed;
        private System.Windows.Forms.Panel colorGray;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}