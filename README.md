# Design Patterns in C# & .NET

A comprehensive, modular repository containing implementations, lecture notes, and runnable examples of the classic **Gang of Four (GoF)** design patterns and core **SOLID principles**, built with modern C# and .NET.

---

## 📂 Solution Structure

Each pattern is encapsulated within its own runnable console project, grouped by category and managed by the root `DesignPatterns.sln` solution file:

```text
design-patterns-csharp-dotnet/
│
├── DesignPatterns.sln
├── README.md
│
├── SOLID/
│   ├── SingleResponsibility/
│   ├── OpenClosed/
│   ├── LiskovSubstitution/
│   ├── InterfaceSegregation/
│   └── DependencyInversion/
│
├── Creational/
│   ├── Factory/
│   ├── AbstractFactory/
│   ├── Builder/
│   ├── Prototype/
│   └── Singleton/
│
├── Structural/
│   ├── Adapter/
│   ├── Bridge/
│   ├── Composite/
│   ├── Decorator/
│   ├── Facade/
│   ├── Flyweight/
│   └── Proxy/
│
└── Behavioral/
    ├── ChainOfResponsibility/
    ├── Command/
    ├── Interpreter/
    ├── Iterator/
    ├── Mediator/
    ├── Memento/
    ├── NullObject/
    ├── Observer/
    ├── State/
    ├── Strategy/
    ├── TemplateMethod/
    └── Visitor/
```

---

## 🚀 Quick Start & How to Run

### Prerequisites
- [.NET 8.0+ SDK / .NET 10 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 / VS Code / JetBrains Rider

### Build Entire Solution
```bash
dotnet build
```

### Run Any Specific Pattern
Execute a specific pattern project directly from the repository root:

```bash
# Examples:
dotnet run --project Creational/Singleton
dotnet run --project Creational/Factory
dotnet run --project Structural/Adapter
dotnet run --project Behavioral/Strategy
```

---

## 🧭 Pattern Progress Checklist & Descriptions

### 🏗️ Creational Patterns
*Creational design patterns deal with object creation mechanisms, optimizing object instantiation to match the system's needs.*

- [x] **Singleton (`Creational/Singleton`)**
  Ensures a class has only one instance while providing a global access point to it. Implemented using thread-safe `Lazy<T>`.
- [ ] **Factory Method (`Creational/Factory`)**
  Provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.
- [ ] **Abstract Factory (`Creational/AbstractFactory`)**
  Provides an interface for creating families of related or dependent objects without specifying their concrete classes.
- [ ] **Builder (`Creational/Builder`)**
  Separates the construction of a complex object from its representation, enabling step-by-step or fluent object assembly.
- [ ] **Prototype (`Creational/Prototype`)**
  Specifies the kinds of objects to create using a prototypical instance, creating new objects by copying/cloning this prototype.

---

### 🏛️ Structural Patterns
*Structural design patterns explain how to assemble objects and classes into larger structures while keeping these structures flexible and efficient.*

- [ ] **Adapter (`Structural/Adapter`)**
  Converts the interface of a class into another interface clients expect, enabling incompatible interfaces to collaborate.
- [ ] **Bridge (`Structural/Bridge`)**
  Decouples an abstraction from its implementation so that the two can vary independently.
- [ ] **Composite (`Structural/Composite`)**
  Composes objects into tree structures to represent part-whole hierarchies, letting clients treat individual objects and compositions uniformly.
- [ ] **Decorator (`Structural/Decorator`)**
  Attaches additional responsibilities to an object dynamically, providing a flexible alternative to subclassing.
- [ ] **Facade (`Structural/Facade`)**
  Provides a unified, high-level interface to a set of interfaces in a subsystem, making the subsystem easier to use.
- [ ] **Flyweight (`Structural/Flyweight`)**
  Minimizes memory usage by sharing as much data as possible with similar objects (intrinsic vs. extrinsic state).
- [ ] **Proxy (`Structural/Proxy`)**
  Provides a surrogate or placeholder for another object to control access, add lazy initialization, caching, or logging.

---

### 🔄 Behavioral Patterns
*Behavioral design patterns identify common communication patterns between objects and increase flexibility in carrying out interaction.*

- [ ] **Chain of Responsibility (`Behavioral/ChainOfResponsibility`)**
  Passes a request along a chain of potential handlers until one of them processes it.
- [ ] **Command (`Behavioral/Command`)**
  Encapsulates a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.
- [ ] **Interpreter (`Behavioral/Interpreter`)**
  Given a language, defines a representation for its grammar along with an interpreter that uses the representation to interpret sentences.
- [ ] **Iterator (`Behavioral/Iterator`)**
  Provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
- [ ] **Mediator (`Behavioral/Mediator`)**
  Defines an object that encapsulates how a set of objects interact, reducing direct dependencies between communicating objects.
- [ ] **Memento (`Behavioral/Memento`)**
  Captures and externalizes an object's internal state without violating encapsulation, allowing the object to be restored later.
- [ ] **Null Object (`Behavioral/NullObject`)**
  Provides a default, non-functional object instead of `null` references to avoid defensive `null`-checking throughout client code.
- [ ] **Observer (`Behavioral/Observer`)**
  Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
- [ ] **State (`Behavioral/State`)**
  Allows an object to alter its behavior when its internal state changes, appearing as if the object changed its class.
- [ ] **Strategy (`Behavioral/Strategy`)**
  Defines a family of algorithms, encapsulates each one, and makes them interchangeable at runtime.
- [ ] **Template Method (`Behavioral/TemplateMethod`)**
  Defines the skeleton of an algorithm in an operation, deferring some steps to subclasses without changing the algorithm structure.
- [ ] **Visitor (`Behavioral/Visitor`)**
  Represents an operation to be performed on the elements of an object structure, letting you define new operations without changing the classes of the elements.

---

### 📐 SOLID Principles Reference

| Principle | Description | Target Patterns |
| :--- | :--- | :--- |
| **S - Single Responsibility** | A class should have only one reason to change. | Facade, Decorator, Command |
| **O - Open/Closed** | Software entities should be open for extension, closed for modification. | Strategy, Factory Method, Decorator |
| **L - Liskov Substitution** | Subtypes must be substitutable for their base types without altering correctness. | Strategy, Template Method |
| **I - Interface Segregation** | Clients should not be forced to depend upon interfaces they do not use. | Adapter, Facade |
| **D - Dependency Inversion** | Depend on abstractions, not concrete implementations. | Abstract Factory, Dependency Injection |

---

## 🛠️ Tech Stack & Conventions

- **Language:** C# 12 / 13+ (.NET 8 / .NET 10)
- **Features Used:** Top-Level Statements, File-Scoped Namespaces, Primary Constructors, Pattern Matching, Record Types, Nullable Reference Types.
- **Design Philosophy:** Clean Code, Thread Safety, SOLID compliance, minimal boilerplate.

---

## 📜 License
This repository is licensed under the [MIT License](LICENSE).
