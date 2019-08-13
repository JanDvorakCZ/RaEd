using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoP_RaEd.Tools
{
    class Eraser : Tool
    {
        public Eraser()
        {
        }

        public override void OnMouseDown(ActionManager manager)
        {
            using (Graphics g = Graphics.FromImage(manager.ImageEdit))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.FillRectangle(new SolidBrush(Color.White), manager.MouseCoordsInImage.X - (manager.ToolSurface / 2) + 1, manager.MouseCoordsInImage.Y - (manager.ToolSurface/2) + 1, manager.ToolSurface, manager.ToolSurface);
                g.Flush();
            }
        }

        public override void OnMouseMove(ActionManager manager)
        {
            using (Graphics g = Graphics.FromImage(manager.ImageEdit))
            {
                for(int xdis = - manager.ToolSurface / 2 ; xdis <= manager.ToolSurface / 2; xdis++)
                {
                    for (int ydis = -manager.ToolSurface / 2; ydis <= manager.ToolSurface / 2; ydis++)
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        g.DrawLine(new Pen(Color.White), manager.MouseCoordsInImage.X - xdis, manager.MouseCoordsInImage.Y - ydis, manager.LastMouseoCoordsInImage.X - xdis, manager.LastMouseoCoordsInImage.Y - ydis);
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
                g.FillRectangle(new SolidBrush(Color.White), manager.MouseCoordsInImage.X - (manager.ToolSurface / 2) + 1, manager.MouseCoordsInImage.Y - (manager.ToolSurface / 2) + 1, manager.ToolSurface, manager.ToolSurface);
                g.Flush();
            }
        }
    }
}
