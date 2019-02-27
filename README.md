# SOLID 
Demonistrate the SOLID Principles

### ` S ` : single- responsibility principle (SRP).
- A class should have one and only one reason to change.
- a class should only have one job.

### ` O ` : open-closed principle (OSP).
- Software entities like classes, modules or functions should be open for extension but closed for modification.
- Any new functionality should be implemented by adding new classes attributes and methods instead of changing the current ones.

### ` L ` : Liskov- substitution principle (LSP).
- If S is a subtype of T, then objects of type T may be replaced with objects of type S.
- This means derived types must be completely substitutable of their base types.

### ` I ` : Interface segregation principle (ISP).
- A client should never be forced to implement an interface that it doesn't use, or clients shouldn't be forced to depend on methods they do not use.
- Instead of having a big interface with too many methods, we can create multiple small interfaces and make the class implement only the interface that it uses.

### ` D ` : Dependency Inversion principle (DIP).
- The high-level module must not depend on the low-level module, but both should depend on abstractions and these abstractions should not depend on details. 
- Abstractions should not depend on details, details should depend on abstractions.
