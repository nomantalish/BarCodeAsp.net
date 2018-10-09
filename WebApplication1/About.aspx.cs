using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Drawing;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        { 
            // *************** Zen BarCode ****************
            Zen.Barcode.BarcodeDraw brcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            var barcodeImage = brcode.Draw(TextBox1.Text, 50);
            //barcodeImage.Save("D://brcodeweb.png");

            // ************ Draw Label For BarCode ****************

            var resultImage = new Bitmap(barcodeImage.Width, barcodeImage.Height + 20); // 20 is bottom padding, adjust to your text

            using (var graphics = Graphics.FromImage(resultImage))
            using (var font = new Font("Consolas", 12))
            using (var brush = new SolidBrush(Color.Black))
            using (var format = new StringFormat()
            {
                Alignment = StringAlignment.Center, // Also, horizontally centered text, as in your example of the expected output
                LineAlignment = StringAlignment.Far
            })
            {
                graphics.Clear(Color.White);
                graphics.DrawImage(barcodeImage, 0, 0);
                graphics.DrawString(TextBox1.Text, font, brush, resultImage.Width / 2, resultImage.Height, format);
            }
             resultImage.Save("D://brcodeweb.png");

            //********* Zen QRCode **********

            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            var qrcodeImage = qrcode.Draw(TextBox1.Text, 5);
            qrcodeImage.Save("D://qrcodeweb.png");
            
             



        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}