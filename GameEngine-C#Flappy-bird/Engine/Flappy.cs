using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    internal class Flappy : Main_class
    {
        //Is jumping allow us to apply some jumping code to our bird
        bool Isjumping = false;
        //Allow to jump will make sure that player pressed space button only once
        bool AllowTojump = true;

        public override void BeginPlay()
        {
            
            shape = ["  ____ ", " {'[]'}", "<{____}>","  ; ; "];
            color = ConsoleColor.Yellow;
            Can_render = true;
            x = 50;
            y = 10;
            h = 5;
            w = 5;

            //Making Physics and collision availiable
            Physics = true;
            Velocity = 0;
            Check_for_collision = true;
            
        }

        public override void Update(float deltaTime)
        {
            //check to see if jumping is true or not.
            //if yes then we set velocity to 10 so that bird jump
            if (Isjumping)
            {
                Velocity = -10f;
                Isjumping = false;
            }
        }


        public override void InputRecieve(Input_system CatchInput)
        {
            //check to see if player pressed space button
            if ((GetAsyncKeyState(VK_SPACE) & 0x8000) != 0)
            {
                //Stop bird from jumping until player released space button
                if (AllowTojump)
                {
                    Isjumping = true;
                    AllowTojump = false;
                   
                }
                
            }
            else
            {
                AllowTojump = true;
            }
        }

       

        public override void Check_collision(Main_class other)
        {
            //if bird hit ground then we make it stop falling
            if (other is ground)
            {
                if (x < other.x + other.w && x + w > other.x && y < other.y + other.h && y + h > other.y)
                {
                    Colliding = true;
                }
                else
                {
                    Colliding = false;
                }
            }
            
            //if bird hit one of a pipes then we stop application.
            if(other is Pipe || other is Pipe2 )
            {
                if (x < other.x + other.w && x + w > other.x && y < other.y + other.h && y + h > other.y)
                {
                    System.Environment.Exit(0) ;
                }
            }
            
        }





    }
}
