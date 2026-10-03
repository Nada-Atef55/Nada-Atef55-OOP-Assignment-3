
namespace src;

public class Store<T>
    where T : class, IHasId
{
    private readonly Dictionary<int, T> _history = new();

    public void Add(T item)
    {
        try
        {
            _history.Add(item.Id, item);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }

    public T? GetById(int id)
    {
        _history.TryGetValue(id, out T? item);
        return item;
    }
    public IReadOnlyDictionary<int, T> GetAll() => _history;
    public void Remove(int id) => _history.Remove(id);
}
