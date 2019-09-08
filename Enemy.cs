using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;
using System.IO;

namespace MyGame
{
    public class Enemy : GameObject, IDraw, IMovableObject
    {
        public Enemy()
        {
            Speed = 3;
            // The first coor of enemies
            X = SwinGame.ScreenWidth() + SwinGame.Rnd(SwinGame.ScreenHeight() + 300) + 500;
            Y = -(SwinGame.Rnd(SwinGame.ScreenWidth() + 500));
        }

        // wrap the enemy
        public void Wrap()
        {
            if (Y > SwinGame.ScreenHeight())
            {
                SetEnemyCoor();
            }
        }

        // moving the enemies
        public void Move()
        {
            Y = Y + Speed;
            Wrap();
        }

        // Set coor for enemies
        public void SetEnemyCoor()
        {
            X = SwinGame.Rnd(SwinGame.ScreenWidth() + 400);
            Y = -(SwinGame.Rnd(SwinGame.ScreenHeight()) + 100);
        }
    }
}






