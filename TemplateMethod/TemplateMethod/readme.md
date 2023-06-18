### Template Method 
- It defines the skeleton of an algorithm in a method, deferring steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
---
- The Template Method pattern suggests that you break down an algorithm into a series of steps, turn these steps into methods, and put a series of calls to these methods inside a single template method. The steps may either be abstract, or have some default implementation. 
-  Use the Template Method pattern when you want to let clients extend only particular steps of an algorithm, but not the whole algorithm or its structure.
-  Use the pattern when you have several classes that contain almost identical algorithms with some minor differences. As a result, you might need to modify all classes when the algorithm changes.
- You might violate the Liskov Substitution Principle by suppressing a default step implementation via a subclass!!
- Template methods tend to be harder to maintain the more steps they have.


![](https://refactoring.guru/images/patterns/diagrams/template-method/structure.png)
- The Abstract Class declares methods that act as steps of an algorithm, as well as the actual template method which calls these methods in a specific order. The steps may either be declared abstract or have some default implementation.
- Concrete Classes can override all of the steps, but not the template method itself.