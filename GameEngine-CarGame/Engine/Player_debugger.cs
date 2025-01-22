using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    internal class Player_debugger : Main_class
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
                
                y = 0;
                color = ConsoleColor.Blue;
                doonce = false;
            }

            if(variables.Player1_statue)
            {
                shape = "Player 1 : :)";
            }
            else
            {
                shape = "Player 1 : :(";
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
