using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace MyRPG
{
    internal class Items
    {
        public int posX;
        public int posY;
        public Image itemImage;
        public int height;
        public int width;
        public string name;

        Random range = new Random();
        int lifeTime = 200;
        public bool expired = false;

        public Items()
        {
            itemImage = Image.FromFile("C:\\Users\\2013.102253\\Downloads/fireball.gif");

            posX = range.Next(9, 573) ;
            posY = range.Next(21, 360);

            height = 20;
            width = 20;


        }

        public void checkLifeTime()
        {

            lifeTime--;
            if (lifeTime < 1 ) 
            {
                expired = true;
            }
        }




    }
}
