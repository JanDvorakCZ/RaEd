/*
 * Author - Jan Dvořák 
 * Email - jdvorula@gmail.com
 */
using System.Drawing;

namespace RoP_RaEd.Tools
{
    class Pencil : Tool
    {
        public Pencil() {   }

        public override void OnMouseDown(ActionManager manager)
        {
            using (Graphics g = Graphics.FromImage(manager.ImageEdit))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.FillRectangle(new SolidBrush(manager.ColorManager.color.ToDefaultColor()), manager.LastMouseoCoordsInImage.X, manager.LastMouseoCoordsInImage.Y, 1, 1);
                g.Flush();
            }
        }

        public override void OnMouseMove(ActionManager manager)
        {
            using (Graphics g = Graphics.FromImage(manager.ImageEdit))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.DrawLine(new Pen(manager.ColorManager.color.ToDefaultColor()), manager.LastMouseoCoordsInImage.X, manager.LastMouseoCoordsInImage.Y, manager.MouseCoordsInImage.X, manager.MouseCoordsInImage.Y);
                g.Flush();
            }
        }

        public override void OnMouseUp(ActionManager manager)
        {
            using (Graphics g = Graphics.FromImage(manager.ImageEdit))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.DrawLine(new Pen(manager.ColorManager.color.ToDefaultColor()), manager.MouseCoordsInImage.X, manager.MouseCoordsInImage.Y, manager.LastMouseoCoordsInImage.X, manager.LastMouseoCoordsInImage.Y);
                g.Flush();
            }
        }
    }
}
