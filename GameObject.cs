using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;
using System.IO;

namespace MyGame
{
    public abstract class GameObject : IDraw
    {
        // Gameobject has X, Y Bitmap and its speed
        public virtual void Draw()
        {
            SwinGame.DrawBitmap(Bitmap, X, Y);
        }

        public float X { get; set; }

        public float Y { get; set; }

        public float Speed { get; set; }

        public Bitmap Bitmap { get; set; }
    }
}
