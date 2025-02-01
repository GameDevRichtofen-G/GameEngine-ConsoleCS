using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    


    internal class Main_class
    {
        public const int VK_W = 0x57;  // W Key
        public const int VK_A = 0x41;  // A Key
        public const int VK_S = 0x53;  // S Key
        public const int VK_D = 0x44;  // D Key
        public const int VK_UP = 0x26;  // Up Arrow
        public const int VK_DOWN = 0x28;  // Down Arrow
        public const int VK_LEFT = 0x25;  // Left Arrow
        public const int VK_RIGHT = 0x27;  // Right Arrow
        public const int VK_SPACE = 0x20;  // Space Bar
        public const int VK_ENTER = 0x0D;  // Enter Key
        public const int VK_ESCAPE = 0x1B;  // Escape Key
        public const int VK_TAB = 0x09;  // Tab Key
        public const int VK_SHIFT = 0x10;  // Shift Key
        public const int VK_CTRL = 0x11;  // Control Key
        public const int VK_ALT = 0x12;  // Alt Key
        public const int VK_F1 = 0x70;  // F1 Key
        public const int VK_F2 = 0x71;  // F2 Key
        public const int VK_F3 = 0x72;  // F3 Key
        public const int VK_F4 = 0x73;  // F4 Key
        public const int VK_F5 = 0x74;  // F5 Key
        public const int VK_F6 = 0x75;  // F6 Key
        public const int VK_F7 = 0x76;  // F7 Key
        public const int VK_F8 = 0x77;  // F8 Key
        public const int VK_F9 = 0x78;  // F9 Key
        public const int VK_F10 = 0x79;  // F10 Key
        public const int VK_F11 = 0x7A;  // F11 Key
        public const int VK_F12 = 0x7B;  // F12 Key
        public const int VK_CAPITAL = 0x14;  // Caps Lock
        public const int VK_BACKSPACE = 0x08;  // Backspace Key
        public const int VK_DELETE = 0x2E;  // Delete Key
        public const int VK_NUMPAD0 = 0x60;  // Numpad 0
        public const int VK_NUMPAD1 = 0x61;  // Numpad 1
        public const int VK_NUMPAD2 = 0x62;  // Numpad 2
        public const int VK_NUMPAD3 = 0x63;  // Numpad 3
        public const int VK_NUMPAD4 = 0x64;  // Numpad 4
        public const int VK_NUMPAD5 = 0x65;  // Numpad 5
        public const int VK_NUMPAD6 = 0x66;  // Numpad 6
        public const int VK_NUMPAD7 = 0x67;  // Numpad 7
        public const int VK_NUMPAD8 = 0x68;  // Numpad 8
        public const int VK_NUMPAD9 = 0x69;  // Numpad 9
        public const int VK_NUMLOCK = 0x90;  // Num Lock
        public const int VK_SCROLL = 0x91;  // Scroll Lock
        public const int VK_HOME = 0x24;  // Home Key
        public const int VK_END = 0x23;  // End Key
        public const int VK_PAGEUP = 0x21;  // Page Up
        public const int VK_PAGEDOWN = 0x22;  // Page Down

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public List<string>  shape = [];//Defines the structure of a class and how the rendering engine processes it for rendering visuals.
        //Example of how to use Shape : shape = ["####","####","####"];
        /*                                                            Output : ####
                                                                               ####
                                                                               ####*/

        public bool Can_render;//A variable that determines whether that render engine can render this class or not 
        public bool spawn = true;//if false, this class will be destroyed.
        public ConsoleColor color;//Determine how render engine render the color of this class a.k.a material
        public ConsoleKeyInfo key;
        public Program programclass;

        


        //Vectors
        public float x = 50;//X coordinates
        public float y = 10;//Y coordinates
        public float z = 0;//Z coordinates(Not available )

        
        



        //Collision && Physics
        public float w = 0;//Width of this class
        public float h = 0;//heigh of this class

        
        public bool Physics = false;//Physics
        public bool Check_for_collision = false;//Can we check for collision or not


        
        public float Gravity = 9.8f;//Gravity of a class
        public float Velocity = 0;//Velocity of a class
        public bool Colliding = false;//Is class colliding with something; Good for stopping gravity
        public Public_variables variables;//Public_variable, variable that allows us to change properties of public_variable class
        public virtual void BeginPlay()
        {
            //will get called on the first frame
        }
        public virtual void Update(float deltaTime)
        {
            //will get called on everyFrame
        }
        

        public virtual void InputRecieve(Input_system CatchInput)
        {
            //Inputs
        }

        public virtual int GetX()
        {
            //return X
            int xx = int.Parse(Math.Round(x).ToString());
            return xx;
        }

        public virtual int GetY()
        {
            int yy = int.Parse(Math.Round(y).ToString());
            return yy;
        }

        public virtual Program GetProgram()
        {
            return programclass;
        }

        public virtual void DestroyThisClass(Main_class Hint)
        {
            
        }

        public virtual void SpawnClass(Main_class SpawnClass,float x, float y,bool Can_render)
        {
                //spawn a class

                //setting up coordinates
                SpawnClass.x = x;
                SpawnClass.y = y;
                SpawnClass.z = 0;


                //setting up some other settings
                SpawnClass.Can_render = true;
                SpawnClass.BeginPlay_Respawn();

            //check to see if this class's Public_classes is available
            if (variables != null)
            {
                 variables.Classes.Add(SpawnClass); //Spawn the class by adding it to Public_class's Classes
            }

            
        }

        public virtual void BeginPlay_Respawn()
        {
            // A function that is called when the class has been spawned.
        }


        public virtual void Check_collision(Main_class other)
        {
            //check for collision function
        }

        //Set the location of a class in one place with SetClassLocation()
        public virtual void SetClassLocation(float X,float Y,float Z)
        {
            x = X; y = Y; z = Z;
        }

       
       
    }

    
}
