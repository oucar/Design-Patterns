### Command Pattern
- Command is a behavioral design pattern that turns a request into a stand-alone object **that contains all information about the request**. This transformation lets you pass requests as a method arguments, delay or queue a request’s execution, and **support undoable operations**.
- Use the Command pattern when you want to **parametrize objects with operations**.
- Use the Command pattern when you want to implement reversible operations.
- Single Responsibility Principle. You can decouple classes that invoke operations from classes that perform these operations. Open/Closed Principle. You can introduce new commands into the app without breaking existing client code
- Downside: the code may become more complicated since you’re introducing a whole new layer between senders and receivers.


![](https://refactoring.guru/images/patterns/diagrams/command/structure.png?id=1cd7833638f4c43630f4a84017d31195)

1) **The Sender** class (aka invoker) is responsible for initiating requests. This class must have a field for storing a reference to a command object. The sender triggers that command instead of sending the request directly to the receiver. Note that the sender isn’t responsible for creating the command object. Usually, it gets a pre-created command from the client via the constructor. <br/><br/>

2) **The Command** interface usually declares just a single method for executing the command.<br/><br/>

3) **Concrete Commands** implement various kinds of requests. A concrete command isn’t supposed to perform the work on its own, but rather to pass the call to one of the business logic objects. However, for the sake of simplifying the code, these classes can be merged. Parameters required to execute a method on a receiving object can be declared as fields in the concrete command. You can make command objects immutable by only allowing the initialization of these fields via the constructor. They define a binding between action and a Receiver. <br/><br/>

4) **The Receiver** class contains some business logic. Almost any object may act as a receiver. Most commands only handle the details of how a request is passed to the receiver, while the receiver itself does the actual work. <br/><br/>

5) **The Client** is responsible for creating a ConcreateCommand and settings its Receiver <br/><br/>