using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    internal class Public_variables
    {
        public List<Main_class> Classes;
        public Dictionary<string, string> sounds = new Dictionary<string, string>
        {
            { "music", "/Audio/pixel-245147.wav" }
        };

        public Main_class Player1;
        public Main_class Player2;

        public bool Player1_statue = true;
        public bool Player2_statue = true;
    }
}
