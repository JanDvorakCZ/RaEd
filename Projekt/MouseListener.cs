/*
 * Author - Jan Dvořák 
 * Email - jdvorula@gmail.com
 */

namespace RoP_RaEd
{
    class MouseListener
    {
        //Declaration of actual possition of mouse and last known possition of mouse
        public int X, Y, lastX,lastY;
        //Declaration of mouse buttons state
        public bool leftMouseDown, rightMouseDown;

        //Constructor that sets mouse initial state
        public MouseListener(int x, int y)
        {
            this.X = x;
            this.Y = y;
            leftMouseDown = false;
            rightMouseDown = false;
        }

        //Changes actual possition to last known and sets new known possition
        public void MouseMoved(int X, int Y)
        {
            lastX = this.X;
            lastY = this.Y;
            this.X = X;
            this.Y = Y;
        }
        //Chages state of left mouse button
        public void LeftMouseDown(bool leftMouse)
        {
            this.leftMouseDown = leftMouse;
        }
        //Changes state of right mouse button
        public void RightMouseDown(bool rightMouse)
        {
            this.rightMouseDown = rightMouse;
        }
    }
}
