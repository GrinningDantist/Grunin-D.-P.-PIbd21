﻿namespace Ships
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
            this.btnMoorCruiser = new System.Windows.Forms.Button();
            this.btnMoorWarship = new System.Windows.Forms.Button();
            this.pickUpMenu = new System.Windows.Forms.GroupBox();
            this.spaceIndexField = new System.Windows.Forms.MaskedTextBox();
            this.warshipPicture = new System.Windows.Forms.PictureBox();
            this.btnPickUp = new System.Windows.Forms.Button();
            this.lblSpace = new System.Windows.Forms.Label();
            this.levelList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).BeginInit();
            this.pickUpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warshipPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingArea
            // 
            this.drawingArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingArea.Location = new System.Drawing.Point(13, 13);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(1006, 485);
            this.drawingArea.TabIndex = 0;
            this.drawingArea.TabStop = false;
            // 
            // btnMoorCruiser
            // 
            this.btnMoorCruiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoorCruiser.BackColor = System.Drawing.Color.White;
            this.btnMoorCruiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoorCruiser.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMoorCruiser.ForeColor = System.Drawing.Color.Black;
            this.btnMoorCruiser.Location = new System.Drawing.Point(1025, 219);
            this.btnMoorCruiser.Name = "btnMoorCruiser";
            this.btnMoorCruiser.Size = new System.Drawing.Size(247, 45);
            this.btnMoorCruiser.TabIndex = 4;
            this.btnMoorCruiser.Text = "ПРИШВАРТОВАТЬ КРЕЙСЕР";
            this.btnMoorCruiser.UseVisualStyleBackColor = false;
            this.btnMoorCruiser.Click += new System.EventHandler(this.btnMoorCruiser_Click);
            // 
            // btnMoorWarship
            // 
            this.btnMoorWarship.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoorWarship.BackColor = System.Drawing.Color.White;
            this.btnMoorWarship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoorWarship.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMoorWarship.ForeColor = System.Drawing.Color.Black;
            this.btnMoorWarship.Location = new System.Drawing.Point(1025, 166);
            this.btnMoorWarship.Name = "btnMoorWarship";
            this.btnMoorWarship.Size = new System.Drawing.Size(247, 47);
            this.btnMoorWarship.TabIndex = 3;
            this.btnMoorWarship.Text = "ПРИШВАРТОВАТЬ ВОЕННЫЙ КОРАБЛЬ";
            this.btnMoorWarship.UseVisualStyleBackColor = false;
            this.btnMoorWarship.Click += new System.EventHandler(this.btnMoorWarship_Click);
            // 
            // pickUpMenu
            // 
            this.pickUpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pickUpMenu.Controls.Add(this.spaceIndexField);
            this.pickUpMenu.Controls.Add(this.warshipPicture);
            this.pickUpMenu.Controls.Add(this.btnPickUp);
            this.pickUpMenu.Controls.Add(this.lblSpace);
            this.pickUpMenu.ForeColor = System.Drawing.Color.White;
            this.pickUpMenu.Location = new System.Drawing.Point(1025, 333);
            this.pickUpMenu.Name = "pickUpMenu";
            this.pickUpMenu.Size = new System.Drawing.Size(247, 165);
            this.pickUpMenu.TabIndex = 5;
            this.pickUpMenu.TabStop = false;
            this.pickUpMenu.Text = "Забрать корабль";
            // 
            // spaceIndexField
            // 
            this.spaceIndexField.BackColor = System.Drawing.Color.White;
            this.spaceIndexField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spaceIndexField.Location = new System.Drawing.Point(51, 19);
            this.spaceIndexField.Name = "spaceIndexField";
            this.spaceIndexField.Size = new System.Drawing.Size(25, 20);
            this.spaceIndexField.TabIndex = 4;
            // 
            // warshipPicture
            // 
            this.warshipPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.warshipPicture.Location = new System.Drawing.Point(6, 82);
            this.warshipPicture.Name = "warshipPicture";
            this.warshipPicture.Size = new System.Drawing.Size(235, 77);
            this.warshipPicture.TabIndex = 3;
            this.warshipPicture.TabStop = false;
            // 
            // btnPickUp
            // 
            this.btnPickUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPickUp.BackColor = System.Drawing.Color.White;
            this.btnPickUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickUp.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPickUp.ForeColor = System.Drawing.Color.Black;
            this.btnPickUp.Location = new System.Drawing.Point(6, 44);
            this.btnPickUp.Name = "btnPickUp";
            this.btnPickUp.Size = new System.Drawing.Size(235, 32);
            this.btnPickUp.TabIndex = 2;
            this.btnPickUp.Text = "ЗАБРАТЬ";
            this.btnPickUp.UseVisualStyleBackColor = false;
            this.btnPickUp.Click += new System.EventHandler(this.btnPickUp_Click);
            // 
            // lblSpace
            // 
            this.lblSpace.AutoSize = true;
            this.lblSpace.Location = new System.Drawing.Point(6, 22);
            this.lblSpace.Name = "lblSpace";
            this.lblSpace.Size = new System.Drawing.Size(39, 13);
            this.lblSpace.TabIndex = 0;
            this.lblSpace.Text = "Место";
            // 
            // levelList
            // 
            this.levelList.FormattingEnabled = true;
            this.levelList.Location = new System.Drawing.Point(1025, 13);
            this.levelList.Name = "levelList";
            this.levelList.Size = new System.Drawing.Size(247, 147);
            this.levelList.TabIndex = 6;
            this.levelList.SelectedIndexChanged += new System.EventHandler(this.levelList_SelectedIndexChanged);
            // 
            // DocksGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1284, 510);
            this.Controls.Add(this.levelList);
            this.Controls.Add(this.pickUpMenu);
            this.Controls.Add(this.btnMoorCruiser);
            this.Controls.Add(this.btnMoorWarship);
            this.Controls.Add(this.drawingArea);
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
        private System.Windows.Forms.Button btnMoorCruiser;
        private System.Windows.Forms.Button btnMoorWarship;
        private System.Windows.Forms.GroupBox pickUpMenu;
        private System.Windows.Forms.PictureBox warshipPicture;
        private System.Windows.Forms.Button btnPickUp;
        private System.Windows.Forms.Label lblSpace;
        private System.Windows.Forms.MaskedTextBox spaceIndexField;
        private System.Windows.Forms.ListBox levelList;
    }
}