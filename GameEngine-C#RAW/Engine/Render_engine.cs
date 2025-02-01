using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    internal class Render_engine
    {
       
        public void Render_engine_func(List<Main_class> Objects) 
        {
            //Refresh the entire console to render the next frame
            Console.Clear();
            
            //check all the classes 
            foreach (var obj in Objects)
            {
                //if this Main_class instance's(obj) Can_render is true, then we render the class 
                if (obj.Can_render)
                {
                    //telling render engine where to draw the class
                    Console.SetCursorPosition(obj.GetX(), obj.GetY());
                    //setting the font color for this class
                    Console.ForegroundColor = obj.color;

                    //rendering the class

                    for (int i = 0;i < obj.shape.Count;i++) 
                    {
                        //if loop was in first stage just print the first element,
                        //if not go i amount down from class Y axis and then print the next element
                        if(i == 0 )
                        {
                            Console.Write(obj.shape[i]);
                        }
                        else
                        {
                            Console.SetCursorPosition(obj.GetX(), obj.GetY() + i);
                            Console.Write(obj.shape[i]);
                        }
                    }
                    
                    

                }
            }
        }
    }
}
