using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using WindowsInput;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;

namespace GameEngine
{
  


    internal class Tanks : Main_class
    {


        Random random = new Random();




        float General_deltaTime;

        int tempX = 0;
        int tempY = 0;

       
        float speed = 4;

        float Random_Time;
        
        public override void BeginPlay()
        {
            spawn = false;
            Can_render = true;
            shape = "-[[]]"; 
            color = ConsoleColor.Yellow;
        }

        public override void BeginPlay_Respawn()
        {
           
            shape = "-[[]]";
            color = ConsoleColor.Yellow;
            Random_Time = random.Next(3,8);
        }

        

        public override void Update(float deltaTime)
        {

            
            //if random time was 0 or less, we will create a bullet class
            if(Random_Time <= 0)
            {
                //create and spawn a bullet class
                Bullet bullet = new Bullet();
                SpawnClass(bullet, x, y, true);
               
                //reseting the random_Time to pick number between 1,7
                Random_Time = random.Next(1, 7);
                
                

            }
            else
            {
                //decreasing 1 value every second from the Random_Time
                Random_Time = Random_Time - deltaTime;
            }



            General_deltaTime = deltaTime;


            if(x > 0)
            {
                if (ConsoleKey.A == key.Key)
                {
                   
                }

                
            }

            if (ConsoleKey.D == key.Key)
            {
                
            }


           

            

            if (ConsoleKey.S == key.Key)
            {
                y = y + (speed * deltaTime);
            }
            tempX = int.Parse(Math.Round(x).ToString());
            tempY = int.Parse(Math.Round(y).ToString());

            
            

            




            //Console.WriteLine("Dick_vector: " + "X : " + x + " Y : " + y + "  Z : " + z);

        }

        public override int GetX()
        {
            int xx = int.Parse(Math.Round(x).ToString());
           

            return xx;
        }

        public override int GetY()
        {

            int yy = int.Parse(Math.Round(y).ToString());

            return yy;
        }

        public override void InputRecieve(Input_system CatchInput)
        {
            
        }

        


    }

    
}
