using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class BeBigger : Skill
    {
        private Timer _timer = new Timer(150); // 5 S == 5000 uS
        private bool clickSpace = false;

        public override void Action()
        {
            // When click the space key, the dog will be bigger and can eat everything
            if (SwinGame.KeyTyped(KeyCode.SpaceKey))
            {
                clickSpace = true;
                
                
                DogMeatData.GameData.Dog.Bitmap = SwinGame.BitmapNamed("IncredibleHulkDog");
                DogMeatData.GameData.Dog.SetDogCoor(DogMeatData.GameData.Dog.X, 150);
                
            }
            /*if (_timer.Time >= _timer.Interval)
            {
                clickSpace = false;

            }*/
            if(_timer.Check())
            {
                clickSpace = false;
            }
            if (clickSpace == true)
            {
                _timer.Tick();
            }
            else if (clickSpace == false)
            {
                DogMeatData.GameData.Dog.Bitmap = SwinGame.BitmapNamed("BraveDog");
                DogMeatData.GameData.Dog.SetDogCoor(DogMeatData.GameData.Dog.X, 300);
                _timer.Time = 0;
            }
            DogMeatData.GameData.Dog.Draw();
        }
    }
}
