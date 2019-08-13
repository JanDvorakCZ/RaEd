/*
 * Author - Jan Dvořák 
 * Email - jdvorula@gmail.com
 */
using System.Drawing;

namespace RoP_RaEd.Tools
{
    class Move : Tool
    {
        private Point _startingPos;
        private bool _mouseDown = false;

        public override void OnMouseDown(ActionManager manager)
        {
            _startingPos = new Point(manager.MouseListener.X, manager.MouseListener.Y);
            _mouseDown = true;
        }

        public override void OnMouseMove(ActionManager manager)
        {
            if (!_mouseDown) return;

            manager.ScrollOffset = new Point(manager.ScrollOffset.X + (manager.MouseListener.X - _startingPos.X), manager.ScrollOffset.Y + (manager.MouseListener.Y - _startingPos.Y));
            _startingPos = new Point(manager.MouseListener.X, manager.MouseListener.Y);
        }

        public override void OnMouseUp(ActionManager manager)
        {
            _mouseDown = false;
        }
    }
}
