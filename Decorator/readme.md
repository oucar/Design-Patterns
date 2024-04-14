## Decorator Pattern

### It attaches additional responsiblites into an object dynamically. Decorators provide a fflexible alternative to sublaclassing for extending functionality.

---

- Decorator is a structural design pattern that lets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the behaviors.

* Inheritance is static. You can’t alter the behavior of an existing object at runtime. You can only replace the whole object with another one that’s created from a different subclass.That's why decorator pattern may be a good fit depending on the design.
* Subclasses can have just one parent class. In most languages, inheritance doesn’t let a class inherit behaviors of multiple classes at the same time.
* Use the Decorator pattern when you need to be able to assign extra behaviors to objects at runtime without breaking the code that uses these objects.
* Use the pattern when it’s awkward or not possible to extend an object’s behavior using inheritance.
*

![Decorator Design UML](https://i.stack.imgur.com/ctCkm.png)
