# Builder - Creational

## Motivation
- Some objects are simple and can be created in a single concsturctor call.
- Other objects may require a lot of ceremony to create.
- Having an object with 10 constructor arguments is not productive.
- Instead, opt for piecewise construction!
- Builder pattern provides an API for constructing an object step-by-step.
- **When piecewise object construction is complicated** --> provide an API for doing it suffeciently.

## When to use?
-  Use the Builder pattern to get rid of a “telescoping constructor”.
```csharp
class Pizza {
    Pizza(int size) { ... }
    Pizza(int size, boolean cheese) { ... }
    Pizza(int size, boolean cheese, boolean pepperoni) { ... }
```
- Use the Builder pattern when you want your code to be able to create different representations of some product (for example, stone and wooden houses).


## So what? 
-  You can construct objects step-by-step, defer construction steps or run steps recursively.
-  You can reuse the same construction code when building various representations of products.
-  Single Responsibility Principle. You can isolate complex construction code from the business logic of the product.

## Note
- I put all the classes, interfaces etc. in one file for the sake of simplicity.