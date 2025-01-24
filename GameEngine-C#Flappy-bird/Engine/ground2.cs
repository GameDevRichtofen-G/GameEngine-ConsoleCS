using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    internal class ground2 : Main_class
    {
        public override void BeginPlay()
        {
            x = 0;
            y = 28;
            shape = [
                   "########################################################################################################################",
                   "########################################################################################################################"];
            color = ConsoleColor.Gray;

            Can_render = true;
        }

        public override void Update(float deltaTime)
        {

        }



    }
}
