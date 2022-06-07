namespace Flappy_Bird
{
    partial class Flappy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flappy));
            this.ground = new System.Windows.Forms.PictureBox();
            this.birdPlayer = new System.Windows.Forms.PictureBox();
            this.obstacleTop = new System.Windows.Forms.PictureBox();
            this.obstacleBottom = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-6, 645);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1131, 194);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            this.ground.Click += new System.EventHandler(this.ground_Click);
            // 
            // birdPlayer
            // 
            this.birdPlayer.BackColor = System.Drawing.Color.Transparent;
            this.birdPlayer.Image = ((System.Drawing.Image)(resources.GetObject("birdPlayer.Image")));
            this.birdPlayer.Location = new System.Drawing.Point(25, 226);
            this.birdPlayer.Name = "birdPlayer";
            this.birdPlayer.Size = new System.Drawing.Size(134, 99);
            this.birdPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.birdPlayer.TabIndex = 1;
            this.birdPlayer.TabStop = false;
            // 
            // obstacleTop
            // 
            this.obstacleTop.BackColor = System.Drawing.Color.Transparent;
            this.obstacleTop.Image = ((System.Drawing.Image)(resources.GetObject("obstacleTop.Image")));
            this.obstacleTop.Location = new System.Drawing.Point(831, 0);
            this.obstacleTop.Name = "obstacleTop";
            this.obstacleTop.Size = new System.Drawing.Size(161, 261);
            this.obstacleTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacleTop.TabIndex = 2;
            this.obstacleTop.TabStop = false;
            this.obstacleTop.UseWaitCursor = true;
            this.obstacleTop.Click += new System.EventHandler(this.obstacleTop_Click);
            // 
            // obstacleBottom
            // 
            this.obstacleBottom.BackColor = System.Drawing.Color.Transparent;
            this.obstacleBottom.Image = ((System.Drawing.Image)(resources.GetObject("obstacleBottom.Image")));
            this.obstacleBottom.Location = new System.Drawing.Point(543, 475);
            this.obstacleBottom.Name = "obstacleBottom";
            this.obstacleBottom.Size = new System.Drawing.Size(172, 228);
            this.obstacleBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacleBottom.TabIndex = 3;
            this.obstacleBottom.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Green;
            this.scoreLabel.Font = new System.Drawing.Font("Luckiest Guy", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(175, 59);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Score:";
            this.scoreLabel.Click += new System.EventHandler(this.scoreLabel_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Green;
            this.scoreText.Font = new System.Drawing.Font("Luckiest Guy", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreText.Location = new System.Drawing.Point(193, 9);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(55, 59);
            this.scoreText.TabIndex = 5;
            this.scoreText.Text = "0";
            // 
            // Flappy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1111, 740);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.obstacleTop);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.birdPlayer);
            this.Controls.Add(this.obstacleBottom);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Name = "Flappy";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.onKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ground;
        private PictureBox birdPlayer;
        private PictureBox obstacleTop;
        private PictureBox obstacleBottom;
        private Label scoreLabel;
        private System.Windows.Forms.Timer gameTimer;
        private Label scoreText;
    }
}