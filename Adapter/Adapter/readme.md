### Adapter Pattern
- Adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate.
- Allows us to use a client with an incompatible interface by creating an Adapter
---
- You can design an adapter so that you can make the external interface work with your existing code without changing your system. Adapter implements the interface our class expect.
- Enumarators and Iterators in Java are real world adapters.
- Use the Adapter class when you want to use some existing class, but its interface isn’t compatible with the rest of your code.  The Adapter pattern lets you create a middle-layer class that serves as a translator between your code and a legacy class, a 3rd-party class or any other class with a weird interface.
-  Single Responsibility Principle. You can separate the interface or data conversion code from the primary business logic of the program.
-  Open/Closed Principle. You can introduce new types of adapters into the program without breaking the existing client code, as long as they work with the adapters through the client interface.
-  The overall complexity of the code increases because you need to introduce a set of new interfaces and classes. Sometimes it’s simpler just to change the service class so that it matches the rest of your code.

---
- Client: The client is implemented aganst the target interface.
    - The client makes a request to the adapter by calling am ethod on it using the target  interface.
- Adapter: The adapter implements the target interface and holds and instance of the Adaptee.
    - The adapter translates the request into one or more calls on the adaptee using the adaptee interface.
- Adaptee: Adaptee interface.
    - The client receives the results of the call and never knows there is an adapter doing the translation. _ADAPTEE and CLIENT are decoupled!_

![Adapter Pattern UML](https://refactoring.guru/images/patterns/diagrams/adapter/structure-object-adapter.png?id=33dffbe3aece294162440c7ddd3d5d4f)