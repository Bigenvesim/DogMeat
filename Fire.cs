using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class Fire : GameObject, IDraw, IMovableObject
    {
        public Fire(float x, float y, float speed)
        {
            Bitmap = SwinGame.BitmapNamed("fire");
            X = x;
            Y = y;
            Speed = speed;
        }

        public void Wrap()
        {
            foreach (Fire fire in DogMeatData.GameData.FireList.ToList())
            {
                if (fire.Y < -50)
                {
                    DogMeatData.GameData.FireList.Remove(fire);
                }
            }
        }

        public void Move()
        {
            Y -= Speed;
            Wrap();
        }
    }
}
