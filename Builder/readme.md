# Builder - Creational

## Motivation
- Some objects are simple and can be created in a single concsturctor call.
- Other objects may require a lot of ceremony to create.
- Having an object with 10 constructor arguments is not productive.
- Instead, opt for piecewise construction!
- Builder pattern provides an API for constructing an object step-by-step.
- **When piecewise object construction is complicated** --> provide an API for doing it suffeciently.

## Note
- I put all the classes, interfaces etc. in one file for the sake of simplicity.