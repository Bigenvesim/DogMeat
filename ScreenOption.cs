using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class ScreenOption
    {
        // Home screen
        public void MenuScreen()
        {
            DogMeatData.GameData.BackGroundImage.SetBackGround("img1");
            SwinGame.PlayMusic("themesong.wav");
            while (!((true == Click(345, 111, 307, 151)) || (true == SwinGame.WindowCloseRequested())))
            {
                SwinGame.ProcessEvents();
                SwinGame.DrawBitmap("play", 345, 111);
                SwinGame.RefreshScreen(60);
            }
            InstructionScreen();
        }

        // Instruction for the game
        public void InstructionScreen()
        {
            SwinGame.DrawBitmap("instruction", 132, 60);
            SwinGame.RefreshScreen(60);
            SwinGame.Delay(5000);
        }
        
        // Choosing character
        public Dog ChoosingCharacter()
        {
            Dog angryDog = new AngryDog();
            Dog braveDog = new BraveDog();
            Dog superDog = new SuperDog();

            Dog result;

            DogMeatData.GameData.BackGroundImage.SetBackGround("img1");
            SwinGame.DrawBitmap("choose", 132, 60);
            SwinGame.DrawBitmap("access", 710, 73);
            SwinGame.DrawBitmap("AngryDog", 170, 200);
            SwinGame.DrawBitmap("BraveDog", 440, 200);
            SwinGame.DrawBitmap("SuperDog", 700, 200);
            SwinGame.FillRectangle(Color.White, 210, 344, 93, 19);
            SwinGame.DrawText("Angry Dog", Color.Black, 222, 349);

            SwinGame.FillRectangle(Color.White, 470, 344, 93, 19);
            SwinGame.DrawText("Brave Dog", Color.Black, 482, 349);

            SwinGame.FillRectangle(Color.White, 722, 344, 93, 19);
            SwinGame.DrawText("Super Dog", Color.Black, 734, 349);

            result = null;

            while (!((true == Click(710, 73, 131, 40)) || (true == SwinGame.WindowCloseRequested())))
            {
                SwinGame.ProcessEvents();
                if (Click(210, 344, 93, 19))
                {
                    SwinGame.FillRectangle(Color.White, 470, 344, 93, 19);
                    SwinGame.DrawText("Brave Dog", Color.Black, 482, 349);
                    SwinGame.FillRectangle(Color.White, 722, 344, 93, 19);
                    SwinGame.DrawText("Super Dog", Color.Black, 734, 349);

                    SwinGame.FillRectangle(Color.Green, 210, 344, 93, 19);
                    SwinGame.DrawText("Angry Dog", Color.Black, 222, 349);
                    SwinGame.RefreshScreen(60);
                    result = angryDog;
                }

                else if (Click(470, 344, 93, 19))
                {
                    SwinGame.FillRectangle(Color.White, 210, 344, 93, 19);
                    SwinGame.DrawText("Angry Dog", Color.Black, 222, 349);
                    SwinGame.FillRectangle(Color.White, 722, 344, 93, 19);
                    SwinGame.DrawText("Super Dog", Color.Black, 734, 349);

                    SwinGame.FillRectangle(Color.Green, 470, 344, 93, 19);
                    SwinGame.DrawText("Brave Dog", Color.Black, 482, 349);
                    SwinGame.RefreshScreen(60);
                    result = braveDog;
                }

                else if (Click(722, 344, 93, 19))
                {
                    SwinGame.FillRectangle(Color.White, 210, 344, 93, 19);
                    SwinGame.DrawText("Angry Dog", Color.Black, 222, 349);
                    SwinGame.FillRectangle(Color.White, 470, 344, 93, 19);
                    SwinGame.DrawText("Brave Dog", Color.Black, 482, 349);

                    SwinGame.FillRectangle(Color.Green, 722, 344, 93, 19);
                    SwinGame.DrawText("Super Dog", Color.Black, 734, 349);
                    SwinGame.RefreshScreen(60);
                    result = superDog;
                }           
                SwinGame.RefreshScreen(60);
            }
            return result;
        }

        // Game over screen and help Reset game
        public void GameOverScreen()
        {
            DogMeatData.GameData.BackGroundImage.SetBackGround("gameoverimg");
            SwinGame.RefreshScreen(60);
            SwinGame.StopMusic();
            SwinGame.Delay(1000);
            SwinGame.PlayMusic("gameovermusic.wav");
            SwinGame.Delay(2000);
            SwinGame.DrawBitmap("gameovertext", 168, -175);
            SwinGame.DrawBitmap("frame", 377, 200);
            SwinGame.DrawText("YOUR SCORE:" + Math.Round(DogMeatData.GameData.Score).ToString(), Color.Black, "maven_pro_regular", 14, 443, 268);
            SwinGame.RefreshScreen(60);
            SwinGame.Delay(2000);
            SwinGame.PlaySoundEffect("Whoosh");
            while (!((true == this.Click(330, 353, 344, 81)) || (true == SwinGame.WindowCloseRequested())))
            {
                SwinGame.ProcessEvents();
                SwinGame.DrawBitmap("replay", 330, 353);
                // Take the screen shot
                if (SwinGame.KeyTyped(KeyCode.SpaceKey))
                {
                    SwinGame.PlaySoundEffect("camerasound");
                    SwinGame.TakeScreenshot("DogMeatGame");
                }
                SwinGame.RefreshScreen(60);
            }
            DogMeatData.GameData.FireList = null;
            SwinGame.StopMusic();
            MenuScreen();
        }

        // Click action method
        public bool Click(float x, float y, int width, int height)
        {
            float positionMouseX;
            float positionMouseY;
            float widthLength;
            float heightLength;

            positionMouseX = SwinGame.MouseX();
            positionMouseY = SwinGame.MouseY();
            widthLength = x + width;
            heightLength = y + height;

            if(SwinGame.MouseClicked(MouseButton.LeftButton))
            {
                if((positionMouseX >= x) && (positionMouseX <= widthLength) && (positionMouseY >= y) && (positionMouseY <= heightLength))
                {
                    SwinGame.PlaySoundEffect("Click");
                    return true;
                }
            }
            return false;  
        }
    }
}
