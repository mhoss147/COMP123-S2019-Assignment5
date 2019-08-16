namespace COMP123_S2019_Assignment5_Mohammad_300763479.Views
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.WelcomePictureBox = new System.Windows.Forms.PictureBox();
            this.SplashLabel = new System.Windows.Forms.Label();
            this.SplashProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.WelcomePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 3000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // WelcomePictureBox
            // 
            this.WelcomePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("WelcomePictureBox.Image")));
            this.WelcomePictureBox.Location = new System.Drawing.Point(0, 188);
            this.WelcomePictureBox.Name = "WelcomePictureBox";
            this.WelcomePictureBox.Size = new System.Drawing.Size(787, 294);
            this.WelcomePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WelcomePictureBox.TabIndex = 0;
            this.WelcomePictureBox.TabStop = false;
            // 
            // SplashLabel
            // 
            this.SplashLabel.Font = new System.Drawing.Font("Brush Script MT", 80F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.SplashLabel.Location = new System.Drawing.Point(12, 23);
            this.SplashLabel.Name = "SplashLabel";
            this.SplashLabel.Size = new System.Drawing.Size(760, 162);
            this.SplashLabel.TabIndex = 3;
            this.SplashLabel.Text = "Dollar Computers";
            this.SplashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashProgressBar
            // 
            this.SplashProgressBar.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.SplashProgressBar.Location = new System.Drawing.Point(132, 488);
            this.SplashProgressBar.MarqueeAnimationSpeed = 10;
            this.SplashProgressBar.Name = "SplashProgressBar";
            this.SplashProgressBar.Size = new System.Drawing.Size(479, 39);
            this.SplashProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.SplashProgressBar.TabIndex = 4;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 584);
            this.ControlBox = false;
            this.Controls.Add(this.SplashProgressBar);
            this.Controls.Add(this.SplashLabel);
            this.Controls.Add(this.WelcomePictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SplashForm";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WelcomePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.PictureBox WelcomePictureBox;
        private System.Windows.Forms.Label SplashLabel;
        private System.Windows.Forms.ProgressBar SplashProgressBar;
    }
}