using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class Health : GameObject, IDraw
    {
        private int _health;

        public Health()
        {
            Bitmap = SwinGame.BitmapNamed("bone");
        }

        public void LostHealth()
        {
            _health--;
        }

        public void GainHealth()
        {
            _health++;
        }

        public int HealthValue
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
        }

        // Draw the player's health (bones)
        public override void Draw ()
        {
            X = 13;
            Y = 18;
            if (HealthValue == 6)
            {
                SwinGame.DrawBitmap(Bitmap, X, Y);
                X += 20;
                SwinGame.DrawBitmap(Bitmap, X, Y);
                X += 20;
                SwinGame.DrawBitmap(Bitmap, X, Y);
                X += 20;
                SwinGame.DrawBitmap(Bitmap, X, Y);
                X += 20;
                SwinGame.DrawBitmap(Bitmap, X, Y);
                X += 20;
                SwinGame.DrawBitmap(Bitmap, X, Y);
            }
            if (HealthValue == 5)
            {
                SwinGame.DrawBitmap(Bitmap, X, Y);
                X += 20;
                SwinGame.DrawBitmap(Bitmap, X, Y);
                X += 20;
                SwinGame.DrawBitmap(Bitmap, X, Y);
                X += 20;
                SwinGame.DrawBitmap(Bitmap, X, Y);
                X += 20;
                SwinGame.DrawBitmap(Bitmap, X, Y);
            }
            if (HealthValue == 4)
            {

                SwinGame.DrawBitmap(Bitmap, X, Y);
                X += 20;
                SwinGame.DrawBitmap(Bitmap, X, Y);
                X += 20;
                SwinGame.DrawBitmap(Bitmap, X, Y);
                X += 20;
                SwinGame.DrawBitmap(Bitmap, X, Y);
            }
            if (HealthValue == 3)
            {
                SwinGame.DrawBitmap(Bitmap, X, Y);
                X += 20;
                SwinGame.DrawBitmap(Bitmap, X, Y);
                X += 20;
                SwinGame.DrawBitmap(Bitmap, X, Y);
            }
            if (HealthValue == 2)
            {
                SwinGame.DrawBitmap(Bitmap, X, Y);
                X += 20;
                SwinGame.DrawBitmap(Bitmap, X, Y);
            }
            if (HealthValue == 1)
            {
                SwinGame.DrawBitmap(Bitmap, X, Y);
            }
        }
    }
}
