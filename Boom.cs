using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class Boom : GameObject, IDraw
    {
        public Boom (float x, float y)
        {
            X = x - 50;
            Y = y - 100;
            Bitmap = SwinGame.BitmapNamed("boom");
        } 
    }
}
