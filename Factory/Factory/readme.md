# Factory, Abstract Factory - Creational
- Provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.
- Replace direct object construction calls with a special factory method.
- Subclasses can override the factory method to change the class of products.
- Objects are still created using the new operator but within the factory method.

## Motivation
- Am I creating an object in a class that is not the best place to create it, or possibly creating the same object in multiple places?
- Use the Factory Method when you want to save system resources by reusing existing objects instead of rebuilding them each time.
- You avoid tight coupling between the creator and the concrete products.
- Single Responsibility Principle. You can move the product creation code into one place in the program, making the code easier to support.
- Open/Closed Principle. You can introduce new types of products into the program without breaking existing client code.

# Note
- I put all the classes, interfaces etc. in one folder for the sake of simplicity.
