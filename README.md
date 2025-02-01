# C# Console Game Engine

## About
This is a simple game engine created in **one day** using C#. It leverages console applications to provide a basic framework for game development.

## Getting Started
### GameEngine-C#RAW
This is the core engine where you can create your own games.
To run it, simply either play in debug mode or run the application directly.

### GameEngine-CarGame
This is a game template created using the engine.
To run it, either play in debug mode or launch the application.

![Example Image](https://github.com/GameDevRichtofen-G/GameEngine-ConsoleCS/blob/master/example.PNG?raw=true)

## `Main_class`
`Main_class` is a type of class that can be used during gameplay.  
You can place it, render it, handle collisions, update it, or destroy it.

### Create Child Classes
To create an instance of `Main_Class`, go to **Solution Explorer** → **Right-click on ProjectName** → **Add** → **New Item**.  
Make sure to update the reference like this:
```csharp
internal class [ClassName] : Main_class
```

### Variables :
`float : ` `x` : x coordinates
`y` : y coordinates
`z` : z coordinates

`w` : width of `Main_class`

`h` : height of `Main_class`

.

`bool` `Check_for_collision` : Can we check for collision or not

`bool` `Can_render` : A variable that determines whether that render engine can render `Main_class` or not 

`bool` `spawn` : if false, this class will be destroyed.

.

`List of String List` `shape` : Defines the structure of a class and how the rendering engine processes it for rendering visuals. `Example : `
```csharp
shape = [["####"]].
```
to render more layers, add more element like this : 
```csharp
shape = [["####"],["####"],"####"];
/*OUTPUT : #####
           #####
           #####*/
```

`ConsoleColor` `color` : Determine how render engine render the color of `Main_class` a.k.a material


## Functions :

To use functions in Main_class instances make sure to override them.
```csharp
public override void BeginPlay()
{
    //will get called on the first frame
}
```

```csharp
public override void BeginPlay_Respawn()
{
    // A function that is called when the class has been spawned.
}
```

```csharp
public override void Update(float deltaTime)
{
    //will get called on everyFrame
}
```

```csharp
public override void InputRecieve(Input_system CatchInput)
{
    //will get called on everyFrame
}
```

```csharp
public override void SpawnClass(Main_class SpawnClass,float x, float y,bool Can_render)
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
```



```csharp
public override void Check_collision(Main_class other)
{
    //check for collision function
    if (other is [TargetClass])
    {
        if (x < other.x + other.w && x + w > other.x && y < other.y + other.h && y + h > other.y)
        {
            
        }
    }
}
```




## BeginPlay function
A function present in every instance of the Main_Class. It is called only during the first frame and can be useful for initializing variables.

### Example
```csharp
public override void BeginPlay()
{
    spawn = true;
    Can_render = true;
    shape = "[[]]"; 
    color = ConsoleColor.Red;
    w = 8;
    h = 1;
    Check_for_collision = true;
}




```
## Update function
A function present in every instance of the Main_Class. It is called every frame and can be useful for updating the class.
## Parameters
`deltaTime` : the time interval in seconds it took from the last frame to the current frame
### Example
```csharp
public override void Update(float deltaTime)
{
    //if bullet's x coordinates was bigger than 5,minus x from speed, else destroy bullet
    if(x > 5)
    {
        x = x - (speed * deltaTime);
    }
    else
    {
        spawn = false;
    }
}
```



## Input System
### How to Use
To handle inputs in your `Main_class`, you need to override the `InputRecieve` method like this:

```csharp
public override void InputRecieve(Input_system CatchInput)
{
    // Handle input logic here
}
```

### Example
Here’s an example of using inputs to move forward when the `W` key is pressed:

```csharp
public override void InputRecieve(Input_system CatchInput)
{
    if ((GetAsyncKeyState(VK_W) & 0x8000) != 0)
    {
        // Move forward when W key is pressed
    }
}
```



## Supported Inputs
Here’s a list of all the inputs you can use in your game:

### Movement Keys
- `VK_W = 0x57` → **W Key**
- `VK_A = 0x41` → **A Key**
- `VK_S = 0x53` → **S Key**
- `VK_D = 0x44` → **D Key**

### Arrow Keys
- `VK_UP = 0x26` → **Up Arrow**
- `VK_DOWN = 0x28` → **Down Arrow**
- `VK_LEFT = 0x25` → **Left Arrow**
- `VK_RIGHT = 0x27` → **Right Arrow**

### Action Keys
- `VK_SPACE = 0x20` → **Space Bar**
- `VK_ENTER = 0x0D` → **Enter Key**
- `VK_ESCAPE = 0x1B` → **Escape Key**
- `VK_TAB = 0x09` → **Tab Key**

### Modifier Keys
- `VK_SHIFT = 0x10` → **Shift Key**
- `VK_CTRL = 0x11` → **Control Key**
- `VK_ALT = 0x12` → **Alt Key**

### Function Keys
- `VK_F1 = 0x70` → **F1 Key**
- `VK_F2 = 0x71` → **F2 Key**
- `VK_F3 = 0x72` → **F3 Key**
- `VK_F4 = 0x73` → **F4 Key**
- `VK_F5 = 0x74` → **F5 Key**
- `VK_F6 = 0x75` → **F6 Key**
- `VK_F7 = 0x76` → **F7 Key**
- `VK_F8 = 0x77` → **F8 Key**
- `VK_F9 = 0x78` → **F9 Key**
- `VK_F10 = 0x79` → **F10 Key**
- `VK_F11 = 0x7A` → **F11 Key**
- `VK_F12 = 0x7B` → **F12 Key**

### Other Keys
- `VK_CAPITAL = 0x14` → **Caps Lock**
- `VK_BACKSPACE = 0x08` → **Backspace Key**
- `VK_DELETE = 0x2E` → **Delete Key**
- `VK_HOME = 0x24` → **Home Key**
- `VK_END = 0x23` → **End Key**
- `VK_PAGEUP = 0x21` → **Page Up**
- `VK_PAGEDOWN = 0x22` → **Page Down**

### Numpad Keys
- `VK_NUMPAD0 = 0x60` → **Numpad 0**
- `VK_NUMPAD1 = 0x61` → **Numpad 1**
- `VK_NUMPAD2 = 0x62` → **Numpad 2**
- `VK_NUMPAD3 = 0x63` → **Numpad 3**
- `VK_NUMPAD4 = 0x64` → **Numpad 4**
- `VK_NUMPAD5 = 0x65` → **Numpad 5**
- `VK_NUMPAD6 = 0x66` → **Numpad 6**
- `VK_NUMPAD7 = 0x67` → **Numpad 7**
- `VK_NUMPAD8 = 0x68` → **Numpad 8**
- `VK_NUMPAD9 = 0x69` → **Numpad 9**
- `VK_NUMLOCK = 0x90` → **Num Lock**
- `VK_SCROLL = 0x91` → **Scroll Lock**


## SpawnClass function
A function that can be use for spawning a new Main_class instance.

## Parameters

`Main_class` as `SpawnClass`
.

`x` : x coordinates

`y` : y coordinates
.

`Can_render` : Determine if class is visible or not

## Example:

`TankClass` :

```csharp
public override void Update(float deltaTime)
{

    
    //if random time was 0 or less, we will create a bullet class
    if(Random_Time <= 0)
    {
        //create and spawn a bullet class
        Bullet bullet = new Bullet();
        SpawnClass(bullet, x, y, true);
       
        //reseting the random_Time to pick number between 1,7
        Random_Time = random.Next(1, 7);
        
        

    }
```


## Check_collision function 
A function that checks whether Main_class instance hit another Main_class instance.

### Parameters 
`Main_class` as `other`

## Example 

```csharp
if (other is Bullet)
{
    /*                             How collision works?
                   first we check if other class is a bullet class
                if yes then we use this formula to check for collision

     𝑥 < 𝑜𝑡ℎ𝑒𝑟.𝑥 + 𝑜𝑡ℎ𝑒𝑟.𝑤 && 𝑥 + 𝑤 > 𝑜𝑡ℎ𝑒𝑟.𝑥 && 𝑦 < 𝑜𝑡ℎ𝑒𝑟.𝑦 + 𝑜𝑡ℎ𝑒𝑟.ℎ && 𝑦 + ℎ > 𝑜𝑡ℎ𝑒𝑟.𝑦

                       if true then we destroy this car class


 */

if (other is Bullet)
{
    if (x < other.x + other.w && x + w > other.x && y < other.y + other.h && y + h > other.y)
    {
        variables.Player1_statue = false;
        other.spawn = false;
        spawn = false;
    }
}
}
```

### NOTE 

you need to set up this function manually


## Destroy class
to destroy a Main_class instance you need to make `spawn` variable false. like this :

```csharp
public void Example_Function()
{
    spawn = false;
}
```
