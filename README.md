# C# Console Game Engine

## About
This is a simple game engine created in **one day** using C#. It leverages console applications to provide a basic framework for game development.

---

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

---

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

---

## Destroy class
to destroy a Main_class instance you need to make `spawn` variable false. like this :

```csharp
public void Example_Function()
{
    spawn = false;
}
```
