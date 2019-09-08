using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class ShootFire : Skill
    {
        private List<Fire> _fireList = new List<Fire>();
       
        public override void Action()
        {
            // If click the spcace key, the dog can shoot fire. Specially, if hold S key and Spacekey, the dog will have the special shooting skill
            if (SwinGame.KeyDown(KeyCode.SKey))
            {
                if (SwinGame.KeyDown(KeyCode.SpaceKey) && DogMeatData.GameData.Score > 5)
                {
                    SwinGame.PlaySoundEffect("Shoot");
                    _fireList.Add(new Fire(DogMeatData.GameData.Dog.X, DogMeatData.GameData.Dog.Y, 5));
                }
            }
            else if (SwinGame.KeyTyped(KeyCode.SpaceKey))
            {
                SwinGame.PlaySoundEffect("Shoot");
                _fireList.Add(new Fire(DogMeatData.GameData.Dog.X, DogMeatData.GameData.Dog.Y, 22));
            }
            foreach (Fire fire in _fireList.ToList())
            {
                fire.Draw();
                fire.Move();
            }
            DogMeatData.GameData.FireList = _fireList;
        }
    }
}
