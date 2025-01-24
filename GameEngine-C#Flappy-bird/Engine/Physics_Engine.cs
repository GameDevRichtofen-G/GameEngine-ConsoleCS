using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    internal class Physics_Engine
    {
        
        
        //List of boolean variabes determining whether Main_class's instance is on a ground
        List<bool> Isground = [];
        
        public void Check_physics(List<Main_class> Classes, float deltaTime)
        {

            for(int i = 0; i < Classes.Count; i++)
            {
                if(Classes[i].Physics)
                {
                    //Check to see we have this class  property
                    if (Isground.Count <= i)
                    {
                        
                        Isground.Add(false);
                        
                        
                    }



                    //Check to see if we are colliding with something or no,
                    //if no, then we will apply gravity formula
                    // 𝑣_𝑦(𝑡) = 𝑣_𝑦₀ + 𝑔 ⋅ 𝑡
                    //if yes then we make velocity false to stop class from falling
                    if (!Classes[i].Colliding)
                    {
                        Classes[i].Velocity += Classes[i].Gravity * deltaTime;
                        Isground[i] = false;
                    }
                    else
                    {
                        if (!Isground[i])
                        {
                            Classes[i].Velocity = 0;
                            Isground[i] = true;
                        }
                        

                        
                    }

                    Classes[i].y += Classes[i].Velocity * deltaTime;


                }
            }
                
        }
    }
}
