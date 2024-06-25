# 01 Introduction to C# and Data Types

1. What type would you choose for the following "numbers"?

- A person's telephone number

    string

- A person's height

    float

- A person's age

    ushort

- A person's gender (Male, Female, Prefer Not To Answer)

    enum

- A person's salary

    uint

- A book's ISBN

    string

- A book's price

    float

- A book's shipping weight

    float

- A country's population

    float

- The number of stars in the universe

    ulong

- The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business)

    uint

2. What are the difference between value type and reference type variables? What is boxing and unboxing?

    Value type variables store the actual value in memory, while reference type variables store the address of the value in memory. Boxing is the process of converting a value type to a reference type, while unboxing is the process of converting a reference type to a value type.

3. What is meant by the terms managed resource and unmanaged resource in .NET?

- Managed resources are resources that are directly handled by the .NET runtime's garbage collector (GC).
- Unmanaged resources are resources that are not directly handled by the .NET runtime's garbage collector (GC) and require manual cleanup. Such as file handles, network connections, database connections, etc.

## Controlling Flow and Converting Types

1. What happens when you divide an int variable by 0?

    An exception is thrown, specifically a `System.DivideByZeroException`.

2. What happens when you divide a double variable by 0?

    The result is `Infinity` or `NaN` depending on the value of the double.

3. What happens when you overflow an int variable, that is, set it to a value beyond its range?

    The value wraps around to the other end of the range.

4. What is the difference between x = y++; and x = ++y;?

    `x = y++;` assigns the value of `y` to `x` and then increments `y`. `x = ++y;` increments `y` and then assigns the value of `y` to `x`.

5. What is the difference between break, continue, and return when used inside a loop
statement?

    - `break` exits the loop.
    - `continue` skips the rest of the loop and goes to the next iteration.
    - `return` exits the method and returns a value.

6. What are the three parts of a for statement and which of them are required?

    - Initialization
    - Condition
    - Iteration
    All three parts are required.

7. What is the difference between the = and == operators?
    
    `=` is the assignment operator, used to assign a value to a variable. `==` is the equality operator, used to compare two values for equality.

8. Does the following statement compile? for ( ; true; ) ;

    Yes, it compiles. It is an infinite loop.

9. What does the underscore _ represent in a switch expression?

    The default case.

10. What interface must an object implement to be enumerated over by using the foreach
statement?

    The `IEnumerable` interface.

## Practice loops and operators

1. The problem with the preceding code is that maximum value of byte is 187. So `i` in the loop will never reach 500, and the loop will run indefinitely. To fix this, you can change the type of `i` to `int` or `long`. The solution could be check whether max is less than byte.MaxValue and then use the loop.

# 02 Arrays and Strings

1. When to use String vs. StringBuilder in C# ?

    - Use `String` when the value is not going to change.
    - Use `StringBuilder` when the value is going to change frequently.

2. What is the base class for all arrays in C#?

    `System.Array`

3. How do you sort an array in C#?

    Use the `Array.Sort()` method to sort an array.

4. What property of an array object can be used to get the total number of elements in
an array?

    The `Length` property.

5. Can you store multiple data types in System.Array?

    Yes, you can store multiple data types in a `System.Array` by using the `object` type.

6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?

    - `CopyTo()` copies the elements of one array to another array.
    - `Clone()` creates a shallow copy of the array.
