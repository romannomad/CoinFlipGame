namespace CoinFlipGame
{
    partial class coinFlipGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coinFlipGame));
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.flipButton = new System.Windows.Forms.Button();
            this.headsLabel = new System.Windows.Forms.Label();
            this.tailsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.Image = ((System.Drawing.Image)(resources.GetObject("imageBox.Image")));
            this.imageBox.Location = new System.Drawing.Point(210, 26);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(406, 372);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // flipButton
            // 
            this.flipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flipButton.Location = new System.Drawing.Point(210, 470);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(406, 76);
            this.flipButton.TabIndex = 1;
            this.flipButton.Text = "Flip";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
            // 
            // headsLabel
            // 
            this.headsLabel.BackColor = System.Drawing.Color.White;
            this.headsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headsLabel.Location = new System.Drawing.Point(215, 415);
            this.headsLabel.Name = "headsLabel";
            this.headsLabel.Size = new System.Drawing.Size(207, 40);
            this.headsLabel.TabIndex = 2;
            this.headsLabel.Text = "Heads:";
            this.headsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tailsLabel
            // 
            this.tailsLabel.BackColor = System.Drawing.Color.White;
            this.tailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tailsLabel.Location = new System.Drawing.Point(428, 415);
            this.tailsLabel.Name = "tailsLabel";
            this.tailsLabel.Size = new System.Drawing.Size(188, 40);
            this.tailsLabel.TabIndex = 3;
            this.tailsLabel.Text = "Tails:";
            this.tailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coinFlipGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(825, 569);
            this.Controls.Add(this.tailsLabel);
            this.Controls.Add(this.headsLabel);
            this.Controls.Add(this.flipButton);
            this.Controls.Add(this.imageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "coinFlipGame";
            this.Text = "Coin Flip Game";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.Label headsLabel;
        private System.Windows.Forms.Label tailsLabel;
    }
}

