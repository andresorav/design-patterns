# OOP Design Patterns implemented in C#

## Creational Patterns

### Abstract Factory Pattern
Offers the interface (abstract factory) for creating a families of related objects (factories), without explicitly specifying their classes.

Useful for creating another abstraction around Factory method pattern.

### Factory Method Pattern
Defines an interface (factory) for creating objects, but let clients to decide which class to instantiate using common interface.

Useful for encapsulating object creation.

### Singleton Pattern
Ensures that a class has only one instance and provides a static method to access it.

Useful when only one instance of a class should be created.

## Structural Patterns

### Adapter Pattern
Converts the interface of a class into another interface clients expect.

Useful when combining the capability of two independent interfaces.

### Decorator Pattern
Allows attaching new behaviors to objects by wrapping these objects inside another. Decorator implements the same interface as the object and delegates the calls to the object it wraps.

Useful when original objects behaviors could not be changed. 

## Behavioral Patterns

### Command Pattern
A request is wrapped under an object as command and passed to invoker object. Invoker object looks for the appropriate object which can handle this command and passes the command to the corresponding object which executes the command.

Executor of the command does not need to know anything at all about what the command is, what context information it needs on or what it does. All of that is encapsulated in the command.
       
### Observer Pattern
Defines a one-to-many dependency between an observable and observer(s) so that when observable changes state, all observers are notified and updated automatically.

Useful when the change of a state in one object must be reflected in another object without keeping the objects tightly coupled.

### Strategy Pattern
Defines a family of algorithms (strategies), encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

Useful for achieving the Single Responsibility Principle and Dependency Inversion Principle.












