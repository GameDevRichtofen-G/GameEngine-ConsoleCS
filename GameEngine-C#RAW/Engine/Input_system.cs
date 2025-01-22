using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using WindowsInput;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;

namespace GameEngine
{
    internal class Input_system
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        // VirtualKeyCode for the 'W' key
        public int VK_W = 0x57;

        public InputSimulator input =  new InputSimulator();


        public void Input_key(List<Main_class> objects)
        {
            if (Console.KeyAvailable)
            {
                
               
            }
            else
            {
                
                
            }

        }
    }
}
