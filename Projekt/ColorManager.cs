/*
 * Author - Jan Dvořák 
 * Email - jdvorula@gmail.com
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoP_RaEd
{
    class ColorManager
    {
        public SeparateColor color;
        public Bitmap ColorFill;

        public ColorManager()
        {
            ColorFill = new Bitmap(100, 100);
            color = new SeparateColor(0,0,0,0);
        }

        public void SetColor(byte alfa, byte R, byte G, byte B)
        {
            color.A = alfa;
            color.R = R;
            color.G = G;
            color.B = B;

            FillColorBitmap();
        }
        private void FillColorBitmap()
        {
            Graphics g = Graphics.FromImage(ColorFill);
            g.Clear(Color.Transparent);
            g.FillRectangle(new SolidBrush(color.ToDefaultColor()), 0,0, 150,150);
            g.Dispose();
        }
        public void SetColor(Color c)
        {

            color.A = c.A;
            color.R = c.R;
            color.G = c.G;
            color.B = c.B;

            FillColorBitmap();
        }
    }
}
