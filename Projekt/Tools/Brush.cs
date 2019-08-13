/*
 * Author - Jan Dvořák 
 * Email - jdvorula@gmail.com
 */
using System.Drawing;

namespace RoP_RaEd.Tools
{
    class Brush : Tool
    {
        public Brush()
        {
        }

        public override void OnMouseDown(ActionManager manager)
        {
            using (Graphics g = Graphics.FromImage(manager.ImageEdit))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                g.FillEllipse(new SolidBrush(manager.ColorManager.color.ToDefaultColor()),
                    manager.MouseCoordsInImage.X - (manager.ToolSurface / 2) + 1,
                    manager.MouseCoordsInImage.Y - (manager.ToolSurface / 2) + 1,
                    manager.ToolSurface, manager.ToolSurface);
                g.Flush();
            }
        }

        public override void OnMouseMove(ActionManager manager)
        {
            using (Graphics g = Graphics.FromImage(manager.ImageEdit))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;

                for (int xdis = -manager.ToolSurface / 2; xdis <= manager.ToolSurface / 2; xdis++)
                {
                    g.DrawLine(new Pen(manager.ColorManager.color.ToDefaultColor()),
                        manager.MouseCoordsInImage.X - xdis,
                        manager.MouseCoordsInImage.Y ,
                        manager.LastMouseoCoordsInImage.X - xdis,
                        manager.LastMouseoCoordsInImage.Y);
                    for (int ydis = -manager.ToolSurface / 2; ydis <= manager.ToolSurface / 2; ydis++)
                    {
                        g.DrawLine(new Pen(manager.ColorManager.color.ToDefaultColor()),
                            manager.MouseCoordsInImage.X,
                            manager.MouseCoordsInImage.Y - ydis,
                            manager.LastMouseoCoordsInImage.X,
                            manager.LastMouseoCoordsInImage.Y - ydis);
                    }
                }
                g.Flush();
            }
        }

        public override void OnMouseUp(ActionManager manager)
        {
            using (Graphics g = Graphics.FromImage(manager.ImageEdit))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                g.FillEllipse(new SolidBrush(manager.ColorManager.color.ToDefaultColor()),
                    manager.MouseCoordsInImage.X - (manager.ToolSurface / 2) + 1,
                    manager.MouseCoordsInImage.Y - (manager.ToolSurface / 2) + 1,
                    manager.ToolSurface, manager.ToolSurface);
                g.Flush();
            }
        }
    }
}
