namespace Ships
{
    partial class DocksGameWindow
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
            this.drawingArea = new System.Windows.Forms.PictureBox();
            this.btnSelectShip = new System.Windows.Forms.Button();
            this.pickUpMenu = new System.Windows.Forms.GroupBox();
            this.spaceIndexField = new System.Windows.Forms.MaskedTextBox();
            this.lblSpace = new System.Windows.Forms.Label();
            this.btnPickUp = new System.Windows.Forms.Button();
            this.warshipPicture = new System.Windows.Forms.PictureBox();
            this.levelList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).BeginInit();
            this.pickUpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warshipPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingArea
            // 
            this.drawingArea.BackColor = System.Drawing.Color.Transparent;
            this.drawingArea.Dock = System.Windows.Forms.DockStyle.Left;
            this.drawingArea.Location = new System.Drawing.Point(0, 0);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(707, 456);
            this.drawingArea.TabIndex = 1;
            this.drawingArea.TabStop = false;
            // 
            // btnSelectShip
            // 
            this.btnSelectShip.BackColor = System.Drawing.Color.White;
            this.btnSelectShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectShip.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectShip.ForeColor = System.Drawing.Color.Black;
            this.btnSelectShip.Location = new System.Drawing.Point(710, 165);
            this.btnSelectShip.Name = "btnSelectShip";
            this.btnSelectShip.Size = new System.Drawing.Size(239, 31);
            this.btnSelectShip.TabIndex = 3;
            this.btnSelectShip.Text = "ВЫБРАТЬ КОРАБЛЬ";
            this.btnSelectShip.UseVisualStyleBackColor = false;
            this.btnSelectShip.Click += new System.EventHandler(this.btnSelectShip_Click);
            // 
            // pickUpMenu
            // 
            this.pickUpMenu.BackColor = System.Drawing.Color.Transparent;
            this.pickUpMenu.Controls.Add(this.spaceIndexField);
            this.pickUpMenu.Controls.Add(this.lblSpace);
            this.pickUpMenu.Controls.Add(this.btnPickUp);
            this.pickUpMenu.Controls.Add(this.warshipPicture);
            this.pickUpMenu.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pickUpMenu.ForeColor = System.Drawing.Color.White;
            this.pickUpMenu.Location = new System.Drawing.Point(711, 292);
            this.pickUpMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pickUpMenu.Name = "pickUpMenu";
            this.pickUpMenu.Padding = new System.Windows.Forms.Padding(2);
            this.pickUpMenu.Size = new System.Drawing.Size(239, 211);
            this.pickUpMenu.TabIndex = 5;
            this.pickUpMenu.TabStop = false;
            this.pickUpMenu.Text = "ЗАБРАТЬ КОРАБЛЬ";
            // 
            // spaceIndexField
            // 
            this.spaceIndexField.BackColor = System.Drawing.Color.White;
            this.spaceIndexField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spaceIndexField.Location = new System.Drawing.Point(45, 19);
            this.spaceIndexField.Margin = new System.Windows.Forms.Padding(2);
            this.spaceIndexField.Mask = "00";
            this.spaceIndexField.Name = "spaceIndexField";
            this.spaceIndexField.Size = new System.Drawing.Size(21, 21);
            this.spaceIndexField.TabIndex = 6;
            // 
            // lblSpace
            // 
            this.lblSpace.Location = new System.Drawing.Point(4, 19);
            this.lblSpace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpace.Name = "lblSpace";
            this.lblSpace.Size = new System.Drawing.Size(37, 21);
            this.lblSpace.TabIndex = 7;
            this.lblSpace.Text = "МЕСТО:";
            this.lblSpace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPickUp
            // 
            this.btnPickUp.BackColor = System.Drawing.Color.White;
            this.btnPickUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickUp.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPickUp.ForeColor = System.Drawing.Color.Black;
            this.btnPickUp.Location = new System.Drawing.Point(5, 45);
            this.btnPickUp.Name = "btnPickUp";
            this.btnPickUp.Size = new System.Drawing.Size(229, 28);
            this.btnPickUp.TabIndex = 2;
            this.btnPickUp.Text = "ЗАБРАТЬ";
            this.btnPickUp.UseVisualStyleBackColor = false;
            this.btnPickUp.Click += new System.EventHandler(this.btnPickUp_Click);
            // 
            // warshipPicture
            // 
            this.warshipPicture.Location = new System.Drawing.Point(4, 79);
            this.warshipPicture.Margin = new System.Windows.Forms.Padding(2);
            this.warshipPicture.Name = "warshipPicture";
            this.warshipPicture.Size = new System.Drawing.Size(231, 128);
            this.warshipPicture.TabIndex = 0;
            this.warshipPicture.TabStop = false;
            // 
            // levelList
            // 
            this.levelList.BackColor = System.Drawing.Color.Black;
            this.levelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.levelList.ForeColor = System.Drawing.Color.White;
            this.levelList.FormattingEnabled = true;
            this.levelList.Location = new System.Drawing.Point(710, 12);
            this.levelList.Name = "levelList";
            this.levelList.Size = new System.Drawing.Size(239, 145);
            this.levelList.TabIndex = 6;
            this.levelList.SelectedIndexChanged += new System.EventHandler(this.levelList_SelectedIndexChanged);
            // 
            // DocksGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(958, 456);
            this.Controls.Add(this.levelList);
            this.Controls.Add(this.pickUpMenu);
            this.Controls.Add(this.btnSelectShip);
            this.Controls.Add(this.drawingArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DocksGameWindow";
            this.Text = "Доки";
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).EndInit();
            this.pickUpMenu.ResumeLayout(false);
            this.pickUpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warshipPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drawingArea;
        private System.Windows.Forms.Button btnSelectShip;
        private System.Windows.Forms.GroupBox pickUpMenu;
        private System.Windows.Forms.PictureBox warshipPicture;
        private System.Windows.Forms.MaskedTextBox spaceIndexField;
        private System.Windows.Forms.Label lblSpace;
        private System.Windows.Forms.Button btnPickUp;
        private System.Windows.Forms.ListBox levelList;
    }
}