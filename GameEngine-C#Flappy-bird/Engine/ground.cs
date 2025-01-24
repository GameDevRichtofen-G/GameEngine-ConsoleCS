using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    internal class ground : Main_class
    {
        public override void BeginPlay()
        {
            x = 0;
            y = 27;
            w = 100;
            h = 5;
            shape = ["########################################################################################################################"
                   ];
            color = ConsoleColor.Green;

            Can_render = true;
        }

        public override void Update(float deltaTime)
        {

        }



    }
}
