// See https://aka.ms/new-console-template for more information

using Assignment4;

void TestQuestion1()
{
    MyStack<int> intStack = new MyStack<int>();
    intStack.Push(1);
    intStack.Push(2);
    intStack.Push(3);

    Console.WriteLine("Count: " + intStack.Count()); // Output: Count: 3
    Console.WriteLine("Popped: " + intStack.Pop()); // Output: Popped: 3
    Console.WriteLine("Count: " + intStack.Count()); // Output: Count: 2

    MyStack<string> stringStack = new MyStack<string>();
    stringStack.Push("A");
    stringStack.Push("B");
    stringStack.Push("C");

    Console.WriteLine("Count: " + stringStack.Count()); // Output: Count: 3
    Console.WriteLine("Popped: " + stringStack.Pop()); // Output: Popped: C
    Console.WriteLine("Count: " + stringStack.Count()); // Output: Count: 2
}

void TestQuestion2()
{
    MyList<int> myList = new MyList<int>();
    myList.Add(1);
    myList.Add(2);
    myList.Add(3);
        
    Console.WriteLine("List contains 2: " + myList.Contains(2)); // Output: True
    Console.WriteLine("Element at index 1: " + myList.Find(1)); // Output: 2

    myList.InsertAt(4, 1);
    Console.WriteLine("Element at index 1 after insertion: " + myList.Find(1)); // Output: 4

    myList.DeleteAt(1);
    Console.WriteLine("Element at index 1 after deletion: " + myList.Find(1)); // Output: 2

    Console.WriteLine("Removed element: " + myList.Remove(1)); // Output: 2
    Console.WriteLine("List contains 2 after removal: " + myList.Contains(2)); // Output: False

    myList.Clear();
    try
    {
        Console.WriteLine("List count after clear: " + myList.Find(0)); // Output: Index is out of range exception
    }
    catch (System.ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
    }

}

TestQuestion1();
TestQuestion2();