# Design Patterns GoF - Technical Documentation

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Design Patterns](https://img.shields.io/badge/Design_Patterns-GoF-blue?style=for-the-badge)

This repository contains a practical and organized library of **Design Patterns** based on the classic book by the **Gang of Four (GoF)**. The goal is to provide clear, well-documented C# implementations to aid learning and applying these concepts in software architecture.

Language support
- English (primary) — `README.md`
- Português (pt-BR) — `README.pt-BR.md`

If you prefer Portuguese, open `README.pt-BR.md`.

## Definition: Design Patterns

Design patterns are reusable solutions to recurring problems in software development. Unlike libraries or frameworks, they are conceptual models that guide system structure and interaction.

This collection aims to:
- Improve code maintainability and scalability.
- Promote reuse of proven solutions.
- Standardize technical communication among developers.

---

## Catalog of Implemented Patterns

Below are the GoF patterns currently present in this repository. Descriptions follow the original definitions from *Design Patterns: Elements of Reusable Object-Oriented Software*.

### Creational
These patterns abstract the instantiation process, making the system independent of how its objects are created, composed, and represented.

| Pattern | GoF Description | Source |
| :--- | :--- | :--- |
| **Singleton** | Ensures a class has only one instance and provides a global point of access to it. | [Folder](./A%20-%20Creational/1%20-%20Singleton/) |
| **Factory Method** | Defines an interface for creating an object, letting subclasses decide which class to instantiate. | [Folder](./A%20-%20Creational/2%20-%20Factory%20Method/) |
| **Abstract Factory** | Provides an interface for creating families of related objects without specifying their concrete classes. | [Folder](./A%20-%20Creational/3%20-%20Abstract%20Factory/) |
| **Builder** | Separates the construction of a complex object from its representation so the same construction process can create different representations. | [Folder](./A%20-%20Creational/4%20-%20Builder/) |
| **Prototype** | Creates new objects by copying a prototypical instance. | [Folder](./A%20-%20Creational/5%20-%20Prototype/) |

### Structural
Deal with object composition and typically help make large structures easier to work with.

| Pattern | GoF Description | Source |
| :--- | :--- | :--- |
| **Adapter** | Converts the interface of a class into another interface clients expect. | [Folder](./B%20-%20Structural/6%20-%20Adapter/) |
| **Bridge** | Decouples an abstraction from its implementation so the two can vary independently. | [Folder](./B%20-%20Structural/7%20-%20Bridge/) |
| **Decorator** | Adds responsibilities to objects dynamically. | [Folder](./B%20-%20Structural/8%20-%20Decorator/) |
| **Composite** | Composes objects into tree structures to represent part-whole hierarchies. | [Folder](./B%20-%20Structural/9%20-%20Composite/) |
| **Facade** | Provides a unified interface to a set of interfaces in a subsystem. | [Folder](./B%20-%20Structural/10%20-%20Facade/) |
| **Proxy** | Provides a surrogate or placeholder for another object to control access to it. | [Folder](./B%20-%20Structural/11%20-%20Proxy/) |
| **Flyweight** | Uses sharing to support large numbers of fine-grained objects efficiently. | [Folder](./B%20-%20Structural/12%20-%20Flyweight/) |

### Behavioral
Behavioral patterns focus on algorithms and the assignment of responsibilities between objects.

| Pattern | GoF Description | Source |
| :--- | :--- | :--- |
| **Template Method** | Defines the skeleton of an algorithm in a method, deferring some steps to subclasses. | [Folder](./C%20-%20Behavioral/13%20-%20Template%20Method/) |
| **Strategy** | Defines a family of algorithms, encapsulates each one, and makes them interchangeable. | [Folder](./C%20-%20Behavioral/14%20-%20Strategy/) |
| **Command** | Encapsulates a request as an object, allowing parameterization, queuing, and undo. | [Folder](./C%20-%20Behavioral/15%20-%20Command/) |
| **Memento** | Captures and externalizes an object's internal state so it can be restored later. | [Folder](./C%20-%20Behavioral/16%20-%20Memento/) |
| **Mediator** | Encapsulates how a set of objects interact to promote loose coupling. | [Folder](./C%20-%20Behavioral/17%20-%20Mediator/) |
| **Chain of Responsibility** | Gives multiple objects a chance to handle a request by passing it along a chain. | [Folder](./C%20-%20Behavioral/18%20-%20Chain%20of%20Responsibility/) |
| **Observer** | Defines a one-to-many dependency so that when one object changes state, its dependents are notified. | [Folder](./C%20-%20Behavioral/19%20-%20Observer/) |
| **State** | Allows an object to change its behavior when its internal state changes. | [Folder](./C%20-%20Behavioral/20%20-%20State/) |
| **Iterator** | Provides sequential access to elements of an aggregate without exposing its representation. | [Folder](./C%20-%20Behavioral/21%20-%20Iterator/) |
| **Visitor** | Represents an operation to be performed on elements of an object structure without changing their classes. | [Folder](./C%20-%20Behavioral/22%20-%20Visitor/) |
| **Interpreter** | Defines a grammar for a language and an interpreter that uses the grammar to interpret sentences. | [Folder](./C%20-%20Behavioral/23%20-%20Interpreter/) |

---
*References: Gamma, Erich; Helm, Richard; Johnson, Ralph; Vlissides, John (1994). Design Patterns: Elements of Reusable Object-Oriented Software.*