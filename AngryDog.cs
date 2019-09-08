using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class AngryDog : Dog
    {
        private Skill _runFaster = new RunFaster();

        // Set the Bitmap for dog
        public AngryDog()
        {
            Bitmap = SwinGame.BitmapNamed("AngryDog");
        }

        // Angry dog has run fast skill
        public override void Skill()
        {
            _runFaster.Action();
        }
    }
}
