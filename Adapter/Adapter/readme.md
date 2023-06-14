### Adapter Pattern
- Adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate.
---
- You can design an adapter so that you can make the external interface work with your existing code without changing your system. Adapter implements the interface our class expect.



---
- Client: The client is implemented aganst the target interface.
    - The client makes a request to the adapter by calling am ethod on it using the target  interface.
- Adapter: The adapter implements the target interface and holds and instance of the Adaptee.
    - The adapter translates the request into one or more calls on the adaptee using the adaptee interface.
- Adaptee: Adaptee interface.
    - The client receives the results of the call and never knows there is an adapter doing the translation. _ADAPTEE and CLIENT are decoupled!_