
### Factory Pattern

##### Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

---

- Objects returned by a factory method are often referred to as _products._
- Use the Factory Method when you don’t know beforehand the exact types and dependencies of the objects your code should work with.
- The Factory Method separates product construction code from the code that actually uses the product. Therefore it’s easier to extend the product construction code independently from the rest of the code.
- Use the Factory Method when you want to provide users of your library or framework with a way to extend its internal components. 
- Use the Factory Method when you want to save system resources by reusing existing objects instead of rebuilding them each time.
- The code may become more complicated since you need to introduce a lot of new subclasses to implement the pattern. The best case scenario is when you’re introducing the pattern into an existing hierarchy of creator classes.
- Great use of Single Responsibility Principle (You can move the product creation code into one place in the program, making the code easier to support.) and Open/Closed Principle (You can introduce new types of products into the program without breaking existing client code.)
-  You avoid tight coupling between the creator and the concrete products.

More can be found [here](https://refactoring.guru/design-patterns/factory-method)


![Factory Pattern Code Example](https://www.oreilly.com/api/v2/epubs/0596007124/files/figs/web/162fig01.png.jpg)

