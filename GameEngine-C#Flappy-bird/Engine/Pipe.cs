using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    internal class Pipe : Main_class
    {
        //Speed
        float speed = 20;
        //List of pipe tiles
        List<string> listofshape = [];
        //Determine how long pipe suppose to be
        public float Lenght = 5;
        public override void BeginPlay()
        {
            spawn = false;
        }


        public override void BeginPlay_Respawn()
        {
            x = 100;
            y = 28;
            
            w = 5;
            //setting up height base on size of a pipe
            h = Lenght + 3;

            //render the head first
            for (int i = 0; i < 3; i++)
            {
                shape.Add("############");
            }

            //render rest of a pipe and move one y up, 
            for (int i = 0; i < Lenght; i++)
            {
                listofshape.Add(" ########## ");
                y = y - 1;
            }
            foreach (string s in listofshape)
            {
                shape.Add(s);
            }



            color = ConsoleColor.DarkGreen
             ;

            Can_render = true;
        }
        public override void Update(float deltaTime)
        {
            //if it pipe's x coordinate was bigger than 5 then it moves to left with additional speed
            //if not destroy pipe
            if (x > 5)
            {
                x = x - (speed * deltaTime);
            }
            else
            {
                spawn = false;
            }
        }


       


    }
}
