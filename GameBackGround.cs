using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class GameBackGround : GameObject, IDraw
    {
        public GameBackGround ()
        {
            X = 0;
            Y = 0;
        }

        // Set game background
        public void SetBackGround (string bitmapNamed)
        {
            Bitmap = SwinGame.BitmapNamed(bitmapNamed);
            Draw();
        }
    }
}
