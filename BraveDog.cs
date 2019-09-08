using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class BraveDog : Dog
    {
        private Skill _beBigger = new BeBigger();

        // Set the Bitmap for dog
        public BraveDog()
        {
            Bitmap = SwinGame.BitmapNamed("BraveDog");
        }

        // Brave dog has transformation skill
        public override void Skill()
        {
            _beBigger.Action();
        }
    }
}
