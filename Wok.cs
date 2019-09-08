using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class Wok : Enemy
    {
        // Set the Bitmap for enemy
        public Wok()
        {
            Bitmap = SwinGame.BitmapNamed("wok");
        }
    }
}
