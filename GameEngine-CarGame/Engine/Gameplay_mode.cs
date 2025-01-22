using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NAudio.Wave;
using System.IO;
using System.Threading.Tasks;


namespace GameEngine
{
    internal class Gameplay_mode : Main_class
    {
        bool doonces = false;

       
        public override void BeginPlay()
        {
            

        }

        public override void Update(float deltaTime)
        {
            if (!doonces)
            {
                for (int i = 0; i < 8; i++)
                {
                    Tanks road = new Tanks();
                    SpawnClass(road, 100, i * 4, true);
                }

                
                doonces = true;
            }

            
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            
            string projectRoot = Directory.GetParent(currentDirectory).Parent.Parent.FullName;

            
            string audioFilePath = Path.Combine(projectRoot, "Audio/pixel-245147.wav");


            using (var audioFile = new AudioFileReader(audioFilePath))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile); // Initialize the device with the audio file
                outputDevice.Play();

            }
        }


      








    }
}
