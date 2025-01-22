using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
  


    internal class Car1 : Main_class
    {


        

        //coordinates
        float x = 50;

        float y = 5;
        float z = 0;


        //General_deltaTime is a variable that can be use in the entire class
        float General_deltaTime;

        int tempX = 0;
        int tempY = 0;

        //Setting the speed of a car
        float speed = 4;

        
        
        public override void BeginPlay()
        {
            spawn = true;
            Can_render = true;
            shape = "[[]]"; 
            color = ConsoleColor.Red;
            w = 8;
            h = 1;
            Check_for_collision = true;
        }




        public override void Update(float deltaTime)
        {
            //setting general deltaTime to an actual deltaTime
            General_deltaTime = deltaTime;













            

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
            //border limit [0,0]
            if ((GetAsyncKeyState(VK_W) & 0x8000) != 0)
            {
                //Move up in y axis
                y = y - (speed * General_deltaTime);
            }

            if ((GetAsyncKeyState(VK_A) & 0x8000) != 0)
            {
                //Move to left in x axis
                x = x - (speed * General_deltaTime);
            }

            if ((GetAsyncKeyState(VK_S) & 0x8000) != 0)
            {
                //Move to down in y axis
                y = y + (speed * General_deltaTime);
            }

            if ((GetAsyncKeyState(VK_D) & 0x8000) != 0)
            {
                //Move to right in x axis
                x = x + (speed * General_deltaTime);
            }

            if ((GetAsyncKeyState(VK_UP) & 0x8000) != 0)
            {
                // Up Arrow key pressed

            }

            if ((GetAsyncKeyState(VK_DOWN) & 0x8000) != 0)
            {
                // Down Arrow key pressed
            }

            if ((GetAsyncKeyState(VK_LEFT) & 0x8000) != 0)
            {
                // Left Arrow key pressed
            }

            if ((GetAsyncKeyState(VK_RIGHT) & 0x8000) != 0)
            {
                // Right Arrow key pressed
            }
        }

        public override void Check_collision(Main_class other)
        {
            /*                             How collision works?
                               first we check if other class is a bullet class
                            if yes then we use this formula to check for collision

                 𝑥 < 𝑜𝑡ℎ𝑒𝑟.𝑥 + 𝑜𝑡ℎ𝑒𝑟.𝑤 && 𝑥 + 𝑤 > 𝑜𝑡ℎ𝑒𝑟.𝑥 && 𝑦 < 𝑜𝑡ℎ𝑒𝑟.𝑦 + 𝑜𝑡ℎ𝑒𝑟.ℎ && 𝑦 + ℎ > 𝑜𝑡ℎ𝑒𝑟.𝑦

                                   if true then we destroy this car class


             */

            if (other is Bullet)
            {
                if (x < other.x + other.w && x + w > other.x && y < other.y + other.h && y + h > other.y)
                {
                    //destroying this car class and the bullet this class got collided with;
                    variables.Player2_statue = false;
                    other.spawn = false;
                    spawn = false;
                }
            }
              
            
        }
    }

    
}
