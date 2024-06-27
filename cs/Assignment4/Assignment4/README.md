# 04 Generics

1. Describe the problem generics address.

- Generics allow us to create classes, interfaces, and methods that operate on a type that is specified when the class, interface, or method is used.

2. How would you create a list of strings, using the generic List class?

```csharp
List<string> list = new List<string>();
```

3. How many generic type parameters does the Dictionary class have?

Two.

4. True/False. When a generic class has multiple type parameters, they must all match.

- False.


5. What method is used to add items to a List object?

- Add

6. Name two methods that cause items to be removed from a List.

- Remove
- RemoveAt

7. How do you indicate that a class has a generic type parameter?

- By placing the type parameter in angle brackets after the class name.

8. True/False. Generic classes can only have one generic type parameter.

- False.

9. True/False. Generic type constraints limit what can be used for the generic type.

- True.

10. True/False. Constraints let you use the methods of the thing you are constraining to.

- True.
