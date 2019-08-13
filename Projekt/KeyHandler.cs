/*
 * Author - Jan Dvořák 
 * Email - jdvorula@gmail.com
 */
using System.Collections;
using System.Windows.Forms;

namespace RoP_RaEd
{
    class KeyHandler
    {
        //Declaration of Hashtable to asociate keys and it's state

        private static Hashtable keyHT = new Hashtable();

        
        public bool keyPressed(Keys key)
        {
            //Checks if value of key in hashtable is not null
            if (keyHT[key] == null)
            {
                return false;
            }
            //Returns value asociated with key
            return (bool)keyHT[key];
        }

        //Changes state of specified key
        public void changeState(Keys key, bool value)
        {
            keyHT[key] = value;
        }
    }
}

