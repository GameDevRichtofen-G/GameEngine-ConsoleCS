



using GameEngine;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Timers;
using System.Transactions;
using System;





DateTime LastFrame = DateTime.Now;// getting the last frame time  

Public_variables Variables = new Public_variables();//Creating a public_variable class;FOR MORE DETAIL CHECK Public_variable.cs

Variables.Classes = DiscoverRelative_class();//Create and store all child classes of the Main_class


//Check all Main_class instances of the Main_Class
foreach (var c in Variables.Classes)
{
    //call BeginPlay function for all Main_class instances on the first frame
    c.BeginPlay();

    

    //Provide each Main_class instance with a reference to the shared public variables
    c.variables = Variables;

    
}
Render_engine engine_d = new Render_engine();  
Input_system input = new Input_system();

List<Main_class> removeMain = new List<Main_class>();

Physics_Engine physics = new Physics_Engine();



while (true)
{
    /*                     Create a DeltaTime variable
           Step 1: Create a variable called currentFrame to store the current computer time.
           Step 2: Calculate deltaTime using the following formula:

             𝛥𝑡 = (𝑡_𝑐𝑢𝑟𝑟𝑒𝑛𝑡 − 𝑡_𝑙𝑎𝑠𝑡).𝑇𝑜𝑡𝑎𝑙𝑆𝑒𝑐𝑜𝑛𝑑𝑠
 
            Step 3: Reset lastFrame to the value of currentFrame.
     
    
     
   */
    DateTime currentFrame = DateTime.Now;
    double deltaTime = (currentFrame - LastFrame).TotalSeconds;
    LastFrame = currentFrame;

    


    float FloatdeltaTime = float.Parse(deltaTime.ToString());

    //Check all Main_class instances of the Main_Class
    foreach (var c in new List<Main_class>(Variables.Classes))
    {
        //Check if Main_class instances spawn variable is true, if not destroy that instance 
        if(c.spawn)
        {
            //Calling Update function and input function for each Main_classes instances every frame
            c.Update(FloatdeltaTime);
            c.InputRecieve(input);
            

            //Checking a copy of Classes list from public_variables class, this allows to check for collision 
            foreach(var i in new List<Main_class>(Variables.Classes))
            {
                //Checking if we can check for collision in  this instance
                if(c.Check_for_collision)
                {
                    c.Check_collision(i);
                }
                
            }
        }
        else if(c.spawn == false)
        {
            //add this class to removeMain list to later on destroy it.  
            removeMain.Add(c);
        }

        //Update Public_class variable for this class to make sure it is uptodate
        c.variables = Variables;


    }


    //check to see if removeMain is an empty list or not
    if (removeMain != null)
    {
        //check for all the Main_class elements 
        foreach (var item in removeMain)
        {
            //remove Main_class instance
            Variables.Classes.Remove(item);
        }

        //reset the removeMain
        removeMain.Clear();
    }


    input.Input_key(Variables.Classes);

    //Checking the physics of all the instances
    physics.Check_physics(Variables.Classes, FloatdeltaTime);
    //Call render function to render all of the Main_class instances
    engine_d.Render_engine_func(Variables.Classes);
    
    
    //simulating Frame Rate,for 60 fps put 16
    System.Threading.Thread.Sleep(16);

    
}




static List<Main_class> DiscoverRelative_class()
{

    // Get the type of the base class (Main_class)
    Type type = typeof(Main_class);


    //Find all non-abstract classes in the current assembly that inherit from Main_class
    IEnumerable<Type> childType = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(type));

    // Create a list to store instances of Main_class and its derived classes
    List<Main_class> instances = new List<Main_class>();

    //Check through all derived class types
    foreach (Type TT in childType)
    {
        //create an instance of the current class
        Main_class instance = (Main_class)Activator.CreateInstance(TT);

        // Check if the instance's spawn property is true, if not we wont spawn it.
        if (instance.spawn)
        {
            instances.Add(instance);
        }    
        
    }
    
    //return instances
    return instances;
}






