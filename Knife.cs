using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class Knife : Enemy
    {
        // Set the Bitmap for enemy
        public Knife()
        {
            Bitmap = SwinGame.BitmapNamed("knife");
        }
    }
}
