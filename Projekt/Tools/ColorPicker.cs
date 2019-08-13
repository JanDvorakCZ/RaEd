/*
 * Author - Jan Dvořák 
 * Email - jdvorula@gmail.com
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RoP_RaEd.Tools
{
    class ColorPicker : Tool
    {
        public ColorPicker()
        {

        }

        public override void OnMouseDown(ActionManager manager)
        {
            try {
                Bitmap bmp = new Bitmap(manager.ImageEdit);
                manager.ColorManager.SetColor(bmp.GetPixel(manager.MouseCoordsInImage.X, manager.MouseCoordsInImage.Y));

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please, select a valid pixel!", "Out of range");
            }
        }
        public override void OnMouseMove(ActionManager manager)
        {
        }

        public override void OnMouseUp(ActionManager manager)
        {
        }
    }
}
