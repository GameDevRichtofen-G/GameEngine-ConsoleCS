using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    internal class Pipe_spawner : Main_class
    {
        public List<List<float>> Possibilties = [[5, 5], [10, 3], [3, 10],[4,6]];
        Random randomTime = new Random();

        float Timespan = 0;
        public override void BeginPlay()
        {
            spawn = true;
            Timespan = randomTime.Next(2,4);
        }

        public override void Update(float deltaTime)
        {
            Timespan = Timespan - deltaTime;
            if(Timespan <= 0 )
            {
                Pipe pipe1 = new Pipe();
                Pipe2 pipe2 = new Pipe2();

                int randomnum = randomTime.Next(0, Possibilties.Count);
                pipe1.Lenght = Possibilties[randomnum][0];
                pipe2.Lenght = Possibilties[randomnum][1];
                SpawnClass(pipe1, 0, 0, true);
                SpawnClass(pipe2 , 0, 0, true);

                Timespan = randomTime.Next(2, 4);
            }
        }



    }
}
