### Observer Pattern

##### Keeps the objects in the know when something they care about happens.

---

-  **The Observer Pattern** defines a one-to-many dependency between objects so that when one object changes state, all of its dependents are notified and updated automatically. 
- One subject notifies many observers. 
- Observer pattern is a great example of a loosely coupled system. Objects typically have very limited knowledge about each other. 
- We can add new observers at any given time.
- We never need to modify the subject to add new types of observers.
- We can reuse subjects or observers independently of each other.
- Observer pattern is like Newspaper publishers and their subscribers, where publisher is the subject and subscribers are the observers.
-

More can be found [here](https://refactoring.guru/design-patterns/observer)

![Visiting store vs. sending spam](https://refactoring.guru/images/patterns/content/observer/observer-comic-1-en.png)


![Structure of the Observer design pattern](https://refactoring.guru/images/patterns/diagrams/observer/structure.png)

![Structure of the Observer pattern example](https://refactoring.guru/images/patterns/diagrams/observer/example.png)