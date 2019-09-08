using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class Lightning : GameObject
    {
        public Lightning (float x, float y)
        {
            X = x;
            Y = y;
        }

        // Draw lightning around Angry Dog
        public override void Draw()
        {
            SwinGame.DrawBitmap(SwinGame.BitmapNamed("light"), X, Y - 3);
            SwinGame.DrawBitmap(SwinGame.BitmapNamed("light1"), X + 30, Y + 48);
        }
    }
}
