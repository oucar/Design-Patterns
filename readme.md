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
--- 
## Inheritance
- A fundamental concept in object-oriented programming (OOP) where a class (subclass/derived class) can inherit properties and behaviors from another class (superclass/base class). It allows for code reuse and the creation of a hierarchy of classes.
## Composition
- Composition is a design principle where a class can be composed of other classes as parts or components. Unlike inheritance, which involves an "is-a" relationship, composition involves a "has-a" relationship. It promotes flexibility and code reuse by allowing objects to be composed of smaller, more manageable components.
- Composition is the flexibility, Inhertiace is the structure. You need to balance these two in order to get good software.
## Aggregation
- Aggregation is a relationship where one object contains another object, but the contained object can exist independently. It's a "has-a" connection, indicating that the whole can be made up of parts, and these parts are not exclusive to a single whole.
## Dependency Injection
- Dependency Injection (DI) is a design pattern where the dependencies of a class are provided from the outside rather than created within the class. This helps in making classes more modular, testable, and maintainable by reducing tight coupling between components.
## Polymorphism
- Polymorphism allows objects of different types to be treated as objects of a common type. This can be achieved through method overriding (runtime polymorphism) or method overloading (compile-time polymorphism). It enables more generic and flexible code, as the same interface can be used with different implementations.
## Encapsulation
- Encapsulation is a principle that involves bundling data (attributes) and methods that operate on that data into a single unit known as a class. It helps in hiding the internal details of an object and exposing only what is necessary. Access to the internal state is controlled through getters and setters.
## Abstraction
- Abstraction is the process of simplifying complex systems by modeling classes based on their essential characteristics. It involves focusing on the relevant details while ignoring unnecessary complexities. Abstract classes and interfaces are used to define the structure and behavior of objects without providing a complete implementation.
## Delegation
- Delegation is a design pattern where an object passes on a task to another object, rather than performing the task itself. It promotes code reuse and flexibility by allowing objects to collaborate and share responsibilities. Delegation is often used in scenarios where a class can benefit from the functionality of another class without being tightly coupled to it.

### Inheritance, Composition, and Aggregation
### Inheritance

- **Relationship Type:** "Is-a" relationship.
- **Nature:** Creates a hierarchy of classes, where a derived class inherits properties and behaviors from a base class.
- **Dependency:** High dependency between the derived and base classes.
- **Reuse:** Promotes code reuse by inheriting features from the base class.
- **Flexibility:** Can lead to a rigid class structure, as changes in the base class may affect derived classes.

### Composition

- **Relationship Type:** "Has-a" relationship.
- **Nature:** Involves creating a class that is composed of other classes as parts or components.
- **Dependency:** Relatively low dependency compared to inheritance.
- **Reuse:** Promotes flexibility and code reuse by allowing objects to be composed of smaller, independent components.
- **Flexibility:** Provides greater flexibility, as changes in one component do not necessarily affect the entire structure.

### Aggregation

- **Relationship Type:** "Has-a" relationship.
- **Nature:** Represents a looser form of composition, where one object contains another, but the contained object can exist independently.
- **Dependency:** Moderate dependency, less strict than composition.
- **Reuse:** Allows for flexibility and sharing of parts among multiple wholes.
- **Flexibility:** Provides a more flexible relationship, as parts can be shared among different wholes without tight coupling.

In summary, while inheritance establishes a hierarchy with high dependency, composition and aggregation offer more flexibility by allowing objects to be composed of smaller, independent parts. Composition involves a stricter relationship, whereas aggregation is more relaxed, allowing parts to exist independently and be shared among different wholes. The choice between them depends on the design goals and the level of coupling desired in a system.


#### Links
- https://www.freecodecamp.org/news/the-basic-design-patterns-all-developers-need-to-know/
- https://www.netsolutions.com/insights/software-design-pattern/
- https://learningdaily.dev/the-7-most-important-software-design-patterns-d60e546afb0e
