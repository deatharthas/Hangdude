Hangdude
========

Hangman as C# console application in 100 lines.  

Created to practice clean coding & refactoring techniques on uncle Bob's Clean Code (http://www.amazon.com/Clean-Code-Handbook-Software-Craftsmanship/dp/0132350882) principles:

- Using meaningful naming conventions, which clearly reveal intentions.
- Small & consice functions that read in a top-down fashion, which either do something or return something - but not both.
- Spare comments that don't mislead or clutter the code with redundant statements
- Well formatted & properly indented source files that are not too wide or long and use same-line open-curlies
- Objects that expose only function or public data members, but not a hybrid of the two
- Unobtrusive error handlers that return typed exceptions, and only where necessary
- Clean boundaries between code & third-party components which should be used only via contracts using interfaces or adapter pattern.
- (F)ast (I)ndependent (R)epeatable (S)elf-validating (T)imely unit tests using the AAA convention, which are written before or at the time that its subjects are coded
- Small classes which follow the SOLID principles so that the can easily be changed
- Clearly abstracted system components, implementing a consistent domain language and using the simplest thing that will work
- Simple emergent design through RCEM (run all tests, contains no duplication, expresses intent, minimize num of classes and methods)
- Seperate classes or methods for thread-aware code blocks, which are not tied to other non-locked regions
- Successive refinement & refactoring of code as soon as possible, using boy scout rule and checking against lettered code smells
