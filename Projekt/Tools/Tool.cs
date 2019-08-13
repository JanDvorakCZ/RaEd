/*
 * Author - Jan Dvořák 
 * Email - jdvorula@gmail.com
 */
namespace RoP_RaEd.Tools
{
    abstract class Tool
    {
        public Tool()
        {   }

        public abstract void OnMouseDown(ActionManager manager);
        public abstract void OnMouseMove(ActionManager manager);
        public abstract void OnMouseUp(ActionManager manager);
    }
}

