using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class Resources 
    {
        // Load all the game resources
        public static void LoadResources()
        {
            // Load Character
            SwinGame.LoadBitmapNamed("AngryDog", "character1.png");
            SwinGame.LoadBitmapNamed("BraveDog", "character2.png");
            SwinGame.LoadBitmapNamed("SuperDog", "character3.png");
            // Load Choose Character screen
            SwinGame.LoadBitmapNamed("choose", "choose.png");
            // Load Enemies
            SwinGame.LoadBitmapNamed("wok", "wok.png");
            SwinGame.LoadBitmapNamed("onion", "onion.png");
            SwinGame.LoadBitmapNamed("knife", "knife.png");
            SwinGame.LoadBitmapNamed("gal", "galangal.png");
            // Load Background level 1
            SwinGame.LoadBitmapNamed("img1", "img.png");
            SwinGame.LoadBitmapNamed("slowimg1", "slowimg1.png");
            // Load Background level 2
            SwinGame.LoadBitmapNamed("img2", "img2.png");
            SwinGame.LoadBitmapNamed("slowimg2", "slowimg2.png");
            // Load Background level 3
            SwinGame.LoadBitmapNamed("img3", "img3.png");
            SwinGame.LoadBitmapNamed("slowimg3", "slowimg3.png");
            // Load Theme music
            SwinGame.LoadMusic("themesong.wav");
            SwinGame.LoadMusic("gameovermusic.wav");
            // Load Sound Effect
            SwinGame.LoadSoundEffectNamed("Bark", "dog.wav");
            SwinGame.LoadSoundEffectNamed("Whoosh", "whoosh.wav");
            SwinGame.LoadSoundEffectNamed("Bite", "bite.wav");
            SwinGame.LoadSoundEffectNamed("Click", "click.wav");
            SwinGame.LoadSoundEffectNamed("Shoot", "shoot.wav");
            SwinGame.LoadSoundEffectNamed("Explosion", "explosion.wav");
            // Load Button play
            SwinGame.LoadBitmapNamed("play", "playbutton.png");
            SwinGame.LoadBitmapNamed("access", "access.png");
            // Load Game over
            SwinGame.LoadBitmapNamed("gameoverimg", "gameoverimg.jpg");//Gameover.jpg
            SwinGame.LoadBitmapNamed("gameovertext", "loose.png");
            // Load Replay button
            SwinGame.LoadBitmapNamed("replay", "replay.png");
            // Load InStruction
            SwinGame.LoadBitmapNamed("instruction", "instruction.png");
            // Load Score Frame
            SwinGame.LoadBitmapNamed("frame", "frame.png");
            // Load Camera Sound
            SwinGame.LoadSoundEffectNamed("camerasound", "camerasound.wav");
            // Load Dog health
            SwinGame.LoadBitmapNamed("bone", "bone.png");
            // Load health stuff
            SwinGame.LoadBitmapNamed("heart", "heart.png");
            // Load Lightning for the dog skill
            SwinGame.LoadBitmapNamed("light", "light.png");
            SwinGame.LoadBitmapNamed("light1", "light1.png");
            // Load newform for the dog skill
            SwinGame.LoadBitmapNamed("IncredibleHulkDog", "DogHulk.png");
            // Load fire for the dog skill
            SwinGame.LoadBitmapNamed("fire", "fire.png");
            // Load effect boom when brave dog shoot enemy
            SwinGame.LoadBitmapNamed("boom", "boom.png");
        }
    }
}
