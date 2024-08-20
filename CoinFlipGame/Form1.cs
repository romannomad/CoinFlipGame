using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinFlipGame
{
    public partial class coinFlipGame : Form
    {
        int heads = 0;
        int tails = 0;
        public coinFlipGame()
        {
            InitializeComponent();
        }

        private void flipButton_Click(object sender, EventArgs e)
        {
            Random coinFlip = new Random();
            int result = coinFlip.Next(1, 3);

            if(result == 1)
            {
                imageBox.ImageLocation = @"D:\C# Projects\Windows Forms Projects\11 Coin Flip Game\1.png";
                imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                heads++;
                headsLabel.Text = "Heads: " + heads.ToString();
            }
            else
            {
                imageBox.ImageLocation = @"D:\C# Projects\Windows Forms Projects\11 Coin Flip Game\2.png";
                imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                tails++;
                tailsLabel.Text = "Tails: " + tails.ToString();
            }
        }
    }
}
