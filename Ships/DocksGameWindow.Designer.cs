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
            this.levelList = new System.Windows.Forms.ListBox();
            this.drawingArea = new System.Windows.Forms.PictureBox();
            this.btnSelectShip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // levelList
            // 
            this.levelList.FormattingEnabled = true;
            this.levelList.ItemHeight = 20;
            this.levelList.Location = new System.Drawing.Point(1076, 20);
            this.levelList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.levelList.Name = "levelList";
            this.levelList.Size = new System.Drawing.Size(170, 224);
            this.levelList.TabIndex = 6;
            this.levelList.SelectedIndexChanged += new System.EventHandler(this.levelList_SelectedIndexChanged);
            // 
            // drawingArea
            // 
            this.drawingArea.BackColor = System.Drawing.Color.Transparent;
            this.drawingArea.Location = new System.Drawing.Point(12, 20);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(1057, 753);
            this.drawingArea.TabIndex = 7;
            this.drawingArea.TabStop = false;
            // 
            // btnSelectShip
            // 
            this.btnSelectShip.BackColor = System.Drawing.Color.White;
            this.btnSelectShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectShip.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectShip.ForeColor = System.Drawing.Color.Black;
            this.btnSelectShip.Location = new System.Drawing.Point(1076, 252);
            this.btnSelectShip.Name = "btnSelectShip";
            this.btnSelectShip.Size = new System.Drawing.Size(170, 38);
            this.btnSelectShip.TabIndex = 9;
            this.btnSelectShip.Text = "ВЫБРАТЬ КОРАБЛЬ";
            this.btnSelectShip.UseVisualStyleBackColor = false;
            this.btnSelectShip.Click += new System.EventHandler(this.btnSelectShip_Click);
            // 
            // DocksGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 785);
            this.Controls.Add(this.btnSelectShip);
            this.Controls.Add(this.drawingArea);
            this.Controls.Add(this.levelList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DocksGameWindow";
            this.Text = "Доки";
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox levelList;
        private System.Windows.Forms.PictureBox drawingArea;
        private System.Windows.Forms.Button btnSelectShip;
    }
}