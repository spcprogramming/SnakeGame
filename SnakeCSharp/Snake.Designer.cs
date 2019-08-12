namespace SnakeCSharp
{
    partial class Snake
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
            this.components = new System.ComponentModel.Container();
            this.mainGraphic = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGraphic
            // 
            this.mainGraphic.Location = new System.Drawing.Point(12, 12);
            this.mainGraphic.Name = "mainGraphic";
            this.mainGraphic.Size = new System.Drawing.Size(848, 625);
            this.mainGraphic.TabIndex = 0;
            this.mainGraphic.TabStop = false;
            this.mainGraphic.Paint += new System.Windows.Forms.PaintEventHandler(this.mainGraphic_Paint);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 649);
            this.Controls.Add(this.mainGraphic);
            this.Name = "Snake";
            this.Text = "Snake";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mainGraphic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainGraphic;
        private System.Windows.Forms.Timer gameTimer;
    }
}

