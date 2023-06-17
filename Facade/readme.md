### Facade Pattern
- Facade is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.
- Provides a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.
- A great, yet simple example of OOP.
---
- With Facade Pattern you can take a complex subsystem and make it easier to use by implementing a Facade class that provides one or more reasonable interface(s). 
-  Use the Facade pattern when you need to have a limited but straightforward interface to a complex subsystem.
-  Create facades to define entry points to each level of a subsystem. You can reduce coupling between multiple subsystems by requiring them to communicate only through facades.
- A facade can become a god object coupled to all classes of an app if not designed properly.


![](https://refactoring.guru/images/patterns/diagrams/facade/live-example-en.png?id=461900f9fbacdd0ce981dcd24e121078)
![](https://refactoring.guru/images/patterns/diagrams/facade/structure.png?id=258401362234ac77a2aaf1cde62339e7)