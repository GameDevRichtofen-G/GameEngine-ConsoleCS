using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    internal class Player_debugger2 : Main_class
    {
        bool doonce = true;
        public override void BeginPlay()
        {
            Can_render = true;
            spawn = true;
        }

        public override void Update(float deltaTime)
        {
            
            
            if (doonce)
            {
                
                
                x = 0;
                
                y = 3;
                color = ConsoleColor.Red;
                doonce = false;
            }

            if (variables.Player2_statue)
            {
                shape = "Player 2 : :)";
            }
            else
            {
                shape = "Player 2 : :(";
                color = ConsoleColor.Gray;
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
