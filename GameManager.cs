using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class GameManager : IDraw
    {
        private Collision _collide = new Collision();
        private ScreenOption _screen = new ScreenOption();
        private RunFaster _runFaster = new RunFaster();
  
        public GameManager()
        {
            SwinGame.OpenGraphicsWindow("DogMeatGame", 1000, 500);
        }

        // Game performance
        public void Perform()
        {
            SwinGame.ProcessEvents();
            if (DogMeatData.GameData.Dog == null)                   // If player does't choose any characters (dog), the game will go back to menu screen
            {
                _screen.MenuScreen();
                SetupGame();
            }
            else
            {
                DogMeatData.GameData.Dog.Move();               // Move the dog
                Draw();                                       // Draw game stuff to the GUI
                DogMeatData.GameData.Dog.Skill();            // Dog skill
                UpdateGame();                               // Update the game in every seconds 
                SwinGame.RefreshScreen(60);
            }
        }

        // Draw everything to the GUI
        public void Draw()
        {
            // Draw background for each level
            if (DogMeatData.GameData.Level == 1)
            {
                DogMeatData.GameData.BackGroundImage.SetBackGround("img1");
            }
            else if(DogMeatData.GameData.Level == 2)
            {
                DogMeatData.GameData.BackGroundImage.SetBackGround("img2");
            }
            else if (DogMeatData.GameData.Level == 3)
            {
                DogMeatData.GameData.BackGroundImage.SetBackGround("img3");
            }
            if (DogMeatData.GameData.Dog.GetType() == typeof(AngryDog))
            {
                _runFaster.BlurBackground();
            }
            // Draw the frame for game information, draw score, health and level
            SwinGame.FillRectangle(Color.Black, 3, 3, 135, 41);
            SwinGame.FillRectangle(Color.Orange, 6, 6, 128, 35);
            SwinGame.DrawText("Score: " + Math.Round(DogMeatData.GameData.Score).ToString(), Color.Red, 8, 9);
            SwinGame.DrawText("Level: " + DogMeatData.GameData.Level.ToString(), Color.Blue, 8, 29);
            DogMeatData.GameData.Dog.Health.Draw();
            // Draw Dog and Draw Enemies
            DogMeatData.GameData.Dog.Draw();
            foreach (Enemy e in DogMeatData.GameData.Enemies)
            {
                e.Draw();
            }
        }

        // Update game in every second
        public void UpdateGame ()
        {
            // Move and check collision for enemies
            foreach (Enemy e in DogMeatData.GameData.Enemies)
            {
                e.Move();
                _collide.CheckCollision();
            }
            // If the dog is SuperDog, it will need the collision checking for Fire hitting Enemies
            if (DogMeatData.GameData.Dog.GetType() == typeof(SuperDog))
            {
                _collide.CheckFireCollision();
            }
            // Set the level based upon Score value
            if (DogMeatData.GameData.Score >= 0)         // Set the level 1 
            {
                DogMeatData.GameData.Level = 1;
                foreach (Enemy e in DogMeatData.GameData.Enemies)
                {
                    e.Speed = 5;
                }
            }
            if (DogMeatData.GameData.Score >= 10)        // Set the level 2
            {
                DogMeatData.GameData.Level = 2;
                foreach(Enemy e in DogMeatData.GameData.Enemies)
                {
                    e.Speed = 7;
                }
            }
            if (DogMeatData.GameData.Score >= 20)        // Set the level 3
            {
                DogMeatData.GameData.Level = 3;
                foreach (Enemy e in DogMeatData.GameData.Enemies)
                {
                    e.Speed = 10;
                }
            }
            // if Dog health == 0, GAME OVER
            if (DogMeatData.GameData.Dog.Health.HealthValue <= 0)       // Game over if Dog health == 0
            {
                _screen.GameOverScreen();
                SetupGame();
            }
        }

        // Setup the enemy
        public void SetupEnemy()
        {
            List<Enemy> list = new List<Enemy>();

            Enemy heart = new Heart();
            Enemy knife = new Knife();
            Enemy gal = new Galangal();
            Enemy onion = new Onion();
            Enemy wok = new Wok();
            Enemy knife1 = new Knife();
            Enemy gal1 = new Galangal();
            Enemy onion1 = new Onion();
            Enemy wok1 = new Wok();

            list.Add(heart);
            list.Add(knife);
            list.Add(gal);
            list.Add(onion);
            list.Add(wok);
            list.Add(knife1);
            list.Add(gal1);
            list.Add(onion1);
            list.Add(wok1);

            DogMeatData.GameData.Enemies = list;
        }

        // Initialize the game data
        public void SetupGame()
        {
            DogMeatData.GameData.Score = 0;
            DogMeatData.GameData.Level = 1;
            SetupEnemy();

            // Choosing character
            DogMeatData.GameData.Dog = _screen.ChoosingCharacter();
        }
    }
}

