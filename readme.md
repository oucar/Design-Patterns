# Solid Design Principles
## Single Responsibility Principle
- A class should have one, and only one, reason to change.
- Each class only does one thing and every class or module only has responsibility for one part of the software’s functionality. More simply, each class should solve only one problem.
- Adding the Save and/or Load functionality to a `Journal` class breaks the SRP. `Journal` itself should be responsible for adding and removing an entry, saving and/or loading an entry to a database requires another class or module to be created.
- Seperation of concerns.
## Open-Closed Principle
- Open for extension, meaning that the class’s behavior can be extended; and
- Closed for modification, meaning that the source code is set and cannot be changed.
## Liskov Substituion Principle
- Every derived class should be substitutable for its parent class.
- Common example of Squares and Rectangles.
```csharp
using static System.Console;

namespace SOLID.LiskovSubstitutionPrinciple
{
  public class Rectangle
  {
    // making them virtual so that we can override them in the Square class
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public Rectangle(){ }

    public Rectangle(int width, int height)
    {
      Width = width;
      Height = height;
    }

    public override string ToString()
    {
      return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
    }
  }

  public class Square : Rectangle
  {

    public override int Width
    {
      set { base.Width = base.Height = value; }
    }

    public override int Height
    { 
      set { base.Width = base.Height = value; }
    }
  }

  public class Demo
  {
    static public int Area(Rectangle r) => r.Width * r.Height;

    static void Main(string[] args)
    {
      Rectangle rc = new Rectangle(2,3);
      WriteLine($"{rc} has area {Area(rc)}");

      // should be able to substitute a base type for a subtype
      /*Square*/ Rectangle sq = new Square();
      sq.Width = 4;
      WriteLine($"{sq} has area {Area(sq)}");
    }
  }
}

```
## Interface Segregation Principle
- It’s better to have a lot of smaller interfaces than a few bigger ones.
- Make fine grained interfaces that are client-specific. Clients should not be forced to implement interfaces they do not use.

## Dependency Inversion Prinple
- Depend on abstractions, not on concretions.
- High level modules should not depend upon low level modules. Both should depend on abstractions.
- Abstractions should not depend on details. Details should depend upon abstractions.
Bad example - In this example, the LightSwitch class depends directly on the concrete implementation of the Bulb class. This creates a tight coupling between the high-level module and the low-level module.
```csharp
// High-level module
public class LightSwitch
{
    private Bulb _bulb;

    public LightSwitch(Bulb bulb)
    {
        _bulb = bulb;
    }

    public void TurnOn()
    {
        _bulb.TurnOn();
    }
}

// Low-level module
public class Bulb
{
    public void TurnOn()
    {
        Console.WriteLine("Bulb turned on");
    }
}

Bulb bulb = new Bulb();
LightSwitch switch = new LightSwitch(bul);
switch.TurnOn();
```

Good example - In this improved example, the LightSwitch class depends on the Switchable abstraction instead of the concrete Bulb class. The Bulb class now inherits from Switchable, making it adhere to the abstraction. This decouples the high-level module from the low-level module, following the Dependency Inversion Principle.
```csharp
// Abstraction
public interface ISwitchable
{
    void TurnOn();
}

// High-level module
public class LightSwitch
{
    private ISwitchable _device;

    public LightSwitch(ISwitchable device)
    {
        _device = device;
    }

    public void TurnOn()
    {
        _device.TurnOn();
    }
}

// Low-level module
public class Bulb : ISwitchable
{
    public void TurnOn()
    {
        Console.WriteLine("Bulb turned on");
    }
}

ISwitchable bulb = new Bulb();
LightSwitch switch = new LightSwitch(bul);
switch.TurnOn();
```

#### Links
- https://www.freecodecamp.org/news/the-basic-design-patterns-all-developers-need-to-know/
- https://www.netsolutions.com/insights/software-design-pattern/
- https://learningdaily.dev/the-7-most-important-software-design-patterns-d60e546afb0e
