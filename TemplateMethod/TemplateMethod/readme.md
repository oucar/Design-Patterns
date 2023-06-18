### Template Method 
- It defines the skeleton of an algorithm in a method, deferring steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
---
- The Template Method pattern suggests that you break down an algorithm into a series of steps, turn these steps into methods, and put a series of calls to these methods inside a single template method. The steps may either be abstract, or have some default implementation. 
-  Use the Template Method pattern when you want to let clients extend only particular steps of an algorithm, but not the whole algorithm or its structure.
-  Use the pattern when you have several classes that contain almost identical algorithms with some minor differences. As a result, you might need to modify all classes when the algorithm changes.
- You might violate the Liskov Substitution Principle by suppressing a default step implementation via a subclass!!
- Template methods tend to be harder to maintain the more steps they have.
- There’s another type of step, called hooks. A hook is an optional step with an empty body. A template method would work even if a hook isn’t overridden. Usually, hooks are placed before and after crucial steps of algorithms, providing subclasses with additional extension points for an algorithm.
- Another good but not really useful example of OOP in bigger apps.

![](https://refactoring.guru/images/patterns/diagrams/template-method/structure.png)
- The Abstract Class declares methods that act as steps of an algorithm, as well as the actual template method which calls these methods in a specific order. The steps may either be declared abstract or have some default implementation.
- Concrete Classes can override all of the steps, but not the template method itself.