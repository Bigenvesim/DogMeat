using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class SuperDog : Dog
    {
        private Skill _shootFire = new ShootFire();

        // Set the Bitmap for dog
        public SuperDog()
        {
            Bitmap = SwinGame.BitmapNamed("SuperDog");
        }

        // Super Dog has shooting fire skill
        public override void Skill()
        {
            _shootFire.Action();
        }
    }
}
