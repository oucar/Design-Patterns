
### Strategy Pattern 
##### Separate the  parts that change from those that stay the same!
---
- **Strategy** is a behavioral design pattern that lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable.
- Use the Strategy when you have a lot of similar classes that only differ in the way they execute some behavior.
- Use the pattern when your class has a massive conditional statement that switches between different variants of the same algorithm.
- Heavily uses composition rather than inheritance, because inheritance might not always be the best for code reuse. You might have to copy and paste over and over again while overriding the methods.
- Decouples the algorithms from the one that uses it.
- Behaviors are encapsulated really well.
- Strategy pattern lets you change behavior at runtime.


More can be found [here](https://refactoring.guru/design-patterns/strategy)
![Route planning strategies](https://refactoring.guru/images/patterns/diagrams/strategy/solution.png)