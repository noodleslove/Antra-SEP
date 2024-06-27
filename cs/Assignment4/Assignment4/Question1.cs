namespace Assignment4;

public class MyStack<T>
{
    private List<T> stackList;

    public MyStack()
    {
        stackList = new List<T>();
    }

    // Method to get the number of elements in the stack
    public int Count()
    {
        return stackList.Count;
    }

    // Method to remove and return the top element of the stack
    public T Pop()
    {
        if (stackList.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        // Get the top element
        T topElement = stackList[stackList.Count - 1];
        // Remove the top element
        stackList.RemoveAt(stackList.Count - 1);
        return topElement;
    }

    // Method to add an element to the top of the stack
    public void Push(T item)
    {
        stackList.Add(item);
    }
}