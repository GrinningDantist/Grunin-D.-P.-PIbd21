namespace Ships
{
    partial class SailingGameWindow
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
            this.btnCruiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingArea
            // 
            this.drawingArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingArea.BackColor = System.Drawing.Color.Transparent;
            this.drawingArea.Location = new System.Drawing.Point(0, 59);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(801, 391);
            this.drawingArea.TabIndex = 0;
            this.drawingArea.TabStop = false;
            // 
            // btnWarship
            // 
            this.btnWarship.BackColor = System.Drawing.Color.White;
            this.btnWarship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarship.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWarship.ForeColor = System.Drawing.Color.Black;
            this.btnWarship.Location = new System.Drawing.Point(12, 13);
            this.btnWarship.Name = "btnWarship";
            this.btnWarship.Size = new System.Drawing.Size(105, 28);
            this.btnWarship.TabIndex = 1;
            this.btnWarship.Text = "ВОЕННЫЙ КОРАБЛЬ";
            this.btnWarship.UseVisualStyleBackColor = false;
            this.btnWarship.Click += new System.EventHandler(this.btnWarship_Click);
            // 
            // btnCruiser
            // 
            this.btnCruiser.BackColor = System.Drawing.Color.White;
            this.btnCruiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCruiser.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCruiser.ForeColor = System.Drawing.Color.Black;
            this.btnCruiser.Location = new System.Drawing.Point(125, 13);
            this.btnCruiser.Name = "btnCruiser";
            this.btnCruiser.Size = new System.Drawing.Size(57, 28);
            this.btnCruiser.TabIndex = 2;
            this.btnCruiser.Text = "КРЕЙСЕР";
            this.btnCruiser.UseVisualStyleBackColor = false;
            this.btnCruiser.Click += new System.EventHandler(this.btnCruiser_Click);
            // 
            // SailingGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCruiser);
            this.Controls.Add(this.btnWarship);
            this.Controls.Add(this.drawingArea);
            this.KeyPreview = true;
            this.Name = "SailingGameWindow";
            this.Text = "Мореплавание";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drawingArea;
        private System.Windows.Forms.Button btnWarship;
        private System.Windows.Forms.Button btnCruiser;
    }
}

