using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class RunFaster : Skill
    {
        public override void Action()
        {
            // When click the spcae key, the dog speed will be increased and the enemies speed is decreased
            if (SwinGame.KeyDown(KeyCode.SpaceKey))
            {
                DogMeatData.GameData.Dog.Speed = 25;
                // Flash effect, when click the space key, the dog will run faster and it will be rounded by lightning
                Lightning light = new Lightning(DogMeatData.GameData.Dog.X, DogMeatData.GameData.Dog.Y);
                light.Draw();
                foreach (Enemy e in DogMeatData.GameData.Enemies)
                {
                    if (DogMeatData.GameData.Level == 1)
                    {
                        e.Speed = 0.9f;
                    }
                    if (DogMeatData.GameData.Level == 2)
                    {
                        e.Speed = 0.9f;
                    }
                    if (DogMeatData.GameData.Level == 3)
                    {
                        e.Speed = 0.9f;
                    }
                }
            }
            else
            {
                DogMeatData.GameData.Dog.Speed = 15;
                foreach (Enemy e in DogMeatData.GameData.Enemies)
                {
                    if (DogMeatData.GameData.Level == 1)
                    {
                        e.Speed = 3;
                    }
                    if (DogMeatData.GameData.Level == 2)
                    {
                        e.Speed = 7;
                    }
                    if (DogMeatData.GameData.Level == 3)
                    {
                        e.Speed = 10;
                    }
                }
            }
        }
        
        // When the dog slows down the time, game background will be blurred 
        public void BlurBackground ()
        {
            if (SwinGame.KeyDown(KeyCode.SpaceKey))
            {
                if (DogMeatData.GameData.Level == 1)
                {
                    DogMeatData.GameData.BackGroundImage.SetBackGround("slowimg1");
                }
                else if (DogMeatData.GameData.Level == 2)
                {
                    DogMeatData.GameData.BackGroundImage.SetBackGround("slowimg2");
                }
                else if (DogMeatData.GameData.Level == 3)
                {
                    DogMeatData.GameData.BackGroundImage.SetBackGround("slowimg3");
                }
            }
        }
    }
}
