using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public abstract class Dog : GameObject, IDraw, IMovableObject
    {
        private Health _health = new Health();

        public Dog()
        {
            _health.HealthValue = 6;
            Speed = 15;
            SetDogCoor(170, 300);
        }
        
        // Dog skill
        public abstract void Skill();

        // Wrap function helps dog go around the screen
        public void Wrap()
        {
            if (X + 100 < -(SwinGame.BitmapWidth(Bitmap)))
            {
                X = SwinGame.ScreenWidth();
            }
            else if (X > SwinGame.ScreenWidth())
            {
                X = -(SwinGame.BitmapWidth(Bitmap));
            }
        }

        // Control the moving of the dog
        public void Move()
        {
            if (SwinGame.KeyDown(KeyCode.RightKey))
            {
                X += Speed;           
                Wrap();
            }
            if (SwinGame.KeyDown(KeyCode.LeftKey))
            {
                X -= Speed;
                Wrap();
            }
        }

        public void SetDogCoor (float x, float y)
        {
            X = x;
            Y = y;
        }

        //  Dog health
        public Health Health
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
    }
}
