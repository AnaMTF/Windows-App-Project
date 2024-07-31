namespace Facultate
{
    partial class LoadingScreen
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
            this.loadingScreenLabel = new System.Windows.Forms.Label();
            this.loadingScreenProgressBar = new System.Windows.Forms.ProgressBar();
            this.loadingScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadingscreenPictureBox = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingscreenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingScreenLabel
            // 
            this.loadingScreenLabel.AutoSize = true;
            this.loadingScreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingScreenLabel.Location = new System.Drawing.Point(247, 180);
            this.loadingScreenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loadingScreenLabel.Name = "loadingScreenLabel";
            this.loadingScreenLabel.Size = new System.Drawing.Size(491, 24);
            this.loadingScreenLabel.TabIndex = 1;
            this.loadingScreenLabel.Text = "Welcome! Please wait for the app to finish loading ♡";
            // 
            // loadingScreenProgressBar
            // 
            this.loadingScreenProgressBar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.loadingScreenProgressBar.Location = new System.Drawing.Point(345, 146);
            this.loadingScreenProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadingScreenProgressBar.Name = "loadingScreenProgressBar";
            this.loadingScreenProgressBar.Size = new System.Drawing.Size(399, 20);
            this.loadingScreenProgressBar.Step = 1;
            this.loadingScreenProgressBar.TabIndex = 2;
            this.loadingScreenProgressBar.UseWaitCursor = true;
            // 
            // loadingScreenTimer
            // 
            this.loadingScreenTimer.Tick += new System.EventHandler(this.loadingScreenTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Facultate.Properties.Resources.kitty;
            this.pictureBox1.Location = new System.Drawing.Point(479, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // loadingscreenPictureBox
            // 
            this.loadingscreenPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.loadingscreenPictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadingscreenPictureBox.Image = global::Facultate.Properties.Resources.loadingscreen;
            this.loadingscreenPictureBox.Location = new System.Drawing.Point(0, 147);
            this.loadingscreenPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadingscreenPictureBox.Name = "loadingscreenPictureBox";
            this.loadingscreenPictureBox.Size = new System.Drawing.Size(1067, 407);
            this.loadingscreenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingscreenPictureBox.TabIndex = 0;
            this.loadingscreenPictureBox.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.loadingScreenProgressBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loadingScreenLabel);
            this.Controls.Add(this.loadingscreenPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingScreen";
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingscreenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loadingscreenPictureBox;
        private System.Windows.Forms.Label loadingScreenLabel;
        private System.Windows.Forms.ProgressBar loadingScreenProgressBar;
        private System.Windows.Forms.Timer loadingScreenTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}