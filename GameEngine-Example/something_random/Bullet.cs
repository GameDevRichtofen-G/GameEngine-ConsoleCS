using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    internal class Bullet : Main_class
    {

        float speed = 8;
        public override void BeginPlay()
        {
            spawn = false;
        }

        public override void BeginPlay_Respawn()
        {
            shape = "<>";
            color = ConsoleColor.White;
            w = 0.5f;
            h = 0.5f;
        }

        public override void Update(float deltaTime)
        {
            //if bullet's x coordinates was bigger than 5,minus x from speed, else destroy bullet
            if(x > 5)
            {
                x = x - (speed * deltaTime);
            }
            else
            {
                spawn = false;
            }
        }

        public override void InputRecieve(Input_system CatchInput)
        {
            

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




    }
}
