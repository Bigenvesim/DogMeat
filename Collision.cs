using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class Collision
    {
        // Check if Enemy hits dog
        public bool EnemyHitDog(Enemy enemy, Dog dog)
        {
            return SwinGame.BitmapCollision(enemy.Bitmap, enemy.X, enemy.Y, dog.Bitmap, dog.X, dog.Y);
        }

        // Check if Fire hits enemy
        public bool EnemyHitFire(Enemy enemy, Fire fire)
        {
            
            return SwinGame.BitmapCollision(enemy.Bitmap, enemy.X, enemy.Y, fire.Bitmap, fire.X ,fire.Y);
        }

        // Check collision between Fire and Enemies
        public void CheckFireCollision ()
        {
            foreach (Fire fire in DogMeatData.GameData.FireList.ToList())
            {
                foreach (Enemy e in DogMeatData.GameData.Enemies)
                {
                    if (EnemyHitFire(e, fire))
                    {
                        DestroyEnemy(e);
                        DogMeatData.GameData.FireList.Remove(fire);
                    }
                }
            }
        }

        // Check collision between enemies and dog
        public void CheckCollision()
        {
            foreach (Enemy e in DogMeatData.GameData.Enemies)
            {
                if (DogMeatData.GameData.Dog.Bitmap != SwinGame.BitmapNamed("IncredibleHulkDog"))    // If dog is Incredible dog, the score doesn't increase and other effects don't happen.
                {
                    if (EnemyHitDog(e, DogMeatData.GameData.Dog))
                    {
                        if (e.Bitmap == SwinGame.BitmapNamed("heart"))                                   // If dog eats heart, the health will be increased by 1
                        {
                            if (DogMeatData.GameData.Dog.Health.HealthValue != 6)
                            {
                                DogMeatData.GameData.Dog.Health.GainHealth();
                            }
                            DogMeatData.GameData.Score += 3f;                                       // If the health is already full (health == 6), when dog eats health, score will be increased by 3         
                            SwinGame.PlaySoundEffect("Bite");
                        }
                        else
                        {
                            SwinGame.PlaySoundEffect("Bark");
                            DogMeatData.GameData.Dog.Health.LostHealth();
                        }
                        e.SetEnemyCoor();
                    }
                    else
                    {
                        DogMeatData.GameData.Score += 0.0002f;
                    }
                }
                else                                                                     // The incredible dog can only destroy the enemies, the score won't increase.      
                {
                    if (EnemyHitDog(e, DogMeatData.GameData.Dog))
                    {
                        DestroyEnemy(e);
                    }
                }
            }
        }

        // Destroy Enemy (Collision effect)
        public void DestroyEnemy(Enemy e)
        {
            Boom boom = new Boom(e.X, e.Y);
            SwinGame.PlaySoundEffect("Explosion");
            boom.Draw();
            e.SetEnemyCoor();
        }
    }
}
