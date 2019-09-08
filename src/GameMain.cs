using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class GameMain
    {
        public static void Main()
        {
            Resources.LoadResources();
            GameManager dogMeatGame = new GameManager();
            ScreenOption screen = new ScreenOption();

            screen.MenuScreen();

            //Run the game 
            dogMeatGame.SetupGame();
            while (false == SwinGame.WindowCloseRequested())
            {
                dogMeatGame.Perform();
            }
            SwinGame.ReleaseAllResources();  
        }  
    }
}































