namespace Ships
{
    partial class GameWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawingArea = new System.Windows.Forms.PictureBox();
            this.btnWarship = new System.Windows.Forms.Button();
            this.btnBattleship = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingArea
            // 
            this.drawingArea.BackColor = System.Drawing.Color.Transparent;
            this.drawingArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.drawingArea.Location = new System.Drawing.Point(0, 90);
            this.drawingArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(1200, 602);
            this.drawingArea.TabIndex = 0;
            this.drawingArea.TabStop = false;
            // 
            // btnWarship
            // 
            this.btnWarship.BackColor = System.Drawing.Color.White;
            this.btnWarship.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWarship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarship.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWarship.ForeColor = System.Drawing.Color.Black;
            this.btnWarship.Location = new System.Drawing.Point(0, 0);
            this.btnWarship.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWarship.Name = "btnWarship";
            this.btnWarship.Size = new System.Drawing.Size(1200, 43);
            this.btnWarship.TabIndex = 1;
            this.btnWarship.Text = "ВОЕННЫЙ КОРАБЛЬ";
            this.btnWarship.UseVisualStyleBackColor = false;
            this.btnWarship.Click += new System.EventHandler(this.btnWarship_Click);
            // 
            // btnBattleship
            // 
            this.btnBattleship.BackColor = System.Drawing.Color.White;
            this.btnBattleship.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBattleship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBattleship.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBattleship.ForeColor = System.Drawing.Color.Black;
            this.btnBattleship.Location = new System.Drawing.Point(0, 43);
            this.btnBattleship.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBattleship.Name = "btnBattleship";
            this.btnBattleship.Size = new System.Drawing.Size(1200, 43);
            this.btnBattleship.TabIndex = 2;
            this.btnBattleship.Text = "ЛИНКОР";
            this.btnBattleship.UseVisualStyleBackColor = false;
            this.btnBattleship.Click += new System.EventHandler(this.btnCruiser_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnBattleship);
            this.Controls.Add(this.btnWarship);
            this.Controls.Add(this.drawingArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GameWindow";
            this.Text = "Корабль";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drawingArea;
        private System.Windows.Forms.Button btnWarship;
        private System.Windows.Forms.Button btnBattleship;
    }
}

