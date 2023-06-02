### Singleton Pattern
- The Singleton Pattern ensures a class has only one instance, and provides a global point access to it.
- We're taking a class and letting it manage a single instance of itself.
- We are also preventing any other class from creating a new instance on its own. To get an instance, you've got to go through the class itself. Its constructor is private.
- We're also providing a global access point to the instance.
-  You avoid tight coupling between the creator and the concrete products. (NOT THE BEST)
- The pattern requires special treatment in a multithreaded environment so that multiple threads won’t create a singleton object several times.
-  It may be difficult to unit test the client code of the Singleton because many test frameworks rely on inheritance when producing mock objects. Since the constructor of the singleton class is private and overriding static methods is impossible in most languages, you will need to think of a creative way to mock the singleton. Or just don’t write the tests. Or don’t use the Singleton pattern.