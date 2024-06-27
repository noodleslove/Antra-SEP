namespace Assignment4;

public class MyList<T>
{
    private List<T> list;

    public MyList()
    {
        list = new List<T>();
    }

    // 1. Add an element to the list
    public void Add(T element)
    {
        list.Add(element);
    }

    // 2. Remove an element at a specific index
    public T Remove(int index)
    {
        if (index < 0 || index >= list.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range.");
        }
        T element = list[index];
        list.RemoveAt(index);
        return element;
    }

    // 3. Check if the list contains a specific element
    public bool Contains(T element)
    {
        return list.Contains(element);
    }

    // 4. Clear all elements from the list
    public void Clear()
    {
        list.Clear();
    }

    // 5. Insert an element at a specific index
    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > list.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range.");
        }
        list.Insert(index, element);
    }

    // 6. Delete an element at a specific index
    public void DeleteAt(int index)
    {
        if (index < 0 || index >= list.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range.");
        }
        list.RemoveAt(index);
    }

    // 7. Find an element at a specific index
    public T Find(int index)
    {
        if (index < 0 || index >= list.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range.");
        }
        return list[index];
    }
}