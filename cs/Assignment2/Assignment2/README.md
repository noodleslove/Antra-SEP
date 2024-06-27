1. What are the six combinations of access modifier keywords and what do they do?

- public: The code is accessible for all classes
- private: The code is only accessible within the same class
- protected: The code is accessible within the same class, or in a class that is inherited from that class.
- internal: The code is only accessible within its own assembly, but not from another assembly.
- protected internal: The code is accessible within the same assembly, or from within a derived class in another assembly.
- private protected: The code is accessible within the same assembly, or from within a derived class in the same assembly.

2. What is the difference between the static, const, and readonly keywords when applied to a type member?

- The static keyword is used to declare members that belong to the type itself rather than to any specific instance.
- The const keyword is used to declare a constant field or local variable.
- The readonly keyword is used to declare a field that can only be assigned a value once.

3. What does a constructor do?

- A constructor is a special method that is used to initialize objects. The constructor is called when an object of a class is created.

4. Why is the partial keyword useful?

- The partial keyword allows a class, struct, or interface to be split into multiple files.

5. What is a tuple?

- A tuple is a data structure that can hold multiple values of different types.

6. What does the C# record keyword do?

- The record keyword is used to define a data structure that represents an immutable value type.

7. What does overloading and overriding mean?

- Overloading is the ability to define multiple methods with the same name but different parameters.
- Overriding is the ability to provide a new implementation for a method that is inherited from a base class.

8. What is the difference between a field and a property?

- A field is a variable that is declared within a class or struct.
- A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field.

9. How do you make a method parameter optional?

- You can make a method parameter optional by providing a default value for the parameter in the method signature.

10. What is an interface and how is it different from abstract class?

- An interface is a reference type that defines a contract for classes to implement. An interface can only contain method signatures, properties, events, and indexers.

11. What accessibility level are members of an interface?

- Members of an interface are implicitly public.

12. True/False. Polymorphism allows derived classes to provide different implementations of the same method.

- True

13. True/False. The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.

- True

14. True/False. The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method.

- False

15. True/False. Abstract methods can be used in a normal (non-abstract) class.

- False

16. True/False. Normal (non-abstract) methods can be used in an abstract class.

- True

17. True/False. Derived classes can override methods that were virtual in the base class.

- True

18. True/False. Derived classes can override methods that were abstract in the base class.

- True

19. True/False. In a derived class, you can override a method that was neither virtual non abstract in the base class.

- False

20. True/False. A class that implements an interface does not have to provide an implementation for all of the members of the interface.

- False

21. True/False. A class that implements an interface is allowed to have other members that aren’t defined in the interface.

- True

22. True/False. A class can have more than one base class.

- False

23. True/False. A class can implement more than one interface.

- True
