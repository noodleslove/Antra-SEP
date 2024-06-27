namespace Assignment4;

interface IRepository<T> where T : Entity
{
    void Add(T item);
    void Remove(T item);
    void Save();
    IEnumerable<T> GetAIl();
    T GetByld(int id);
}

public abstract class Entity
{
    public int Id { get; set; }
}

public class GenericRepository<T> : IRepository<T> where T : Entity
{
    private readonly List<T> _context;
    
    public GenericRepository()
    {
        _context = new List<T>();
    }
    
    public void Add(T item)
    {
        _context.Add(item);
    }

    public void Remove(T item)
    {
        _context.Remove(item);
    }

    public void Save()
    {
        Console.WriteLine("Perform save");
    }

    public IEnumerable<T> GetAIl()
    {
        return _context;
    }

    public T GetByld(int id)
    {
        return _context.FirstOrDefault(e => e.Id == id);
    }
}