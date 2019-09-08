using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class DogMeatData
    {
        private static DogMeatData _gameData;

        // Design pattern SINGLETON
        public static DogMeatData GameData
        {
            get
            {
                if (_gameData == null)
                {
                    _gameData = new DogMeatData();
                }
                return _gameData;
            }
        }

        // Game Data: the game data includes List of Fire, the Dog, the Enemies, Level Score and BackGround
        public List<Fire> FireList { get; set; }
      
        public Dog Dog { get; set; }

        public List<Enemy> Enemies { get; set; }

        public int Level { get; set; }

        public float Score { get; set; }

        public GameBackGround BackGroundImage { get; set; } = new GameBackGround();
    }
}

