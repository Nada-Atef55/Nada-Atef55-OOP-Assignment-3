
namespace src;

public static class EnumerableExtensions
{
    public static T? FindById<T>(this IEnumerable<T> items, int id)
        where T : IHasId
    {
        foreach(var item in items)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return default;
    }


    public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(this IEnumerable<T> items)
        where T : IHasId
    {
        Dictionary<int, T> temp = new();
        foreach(var item in items)
        {
            temp.Add(item.Id, item);
        }
        return temp;
    }


    public static IEnumerable<T> Page<T>(this IEnumerable<KeyValuePair<int,T>> items, int pageNumber, int pageSize) 
    {
        // ceiling (items.Count() / pageSize) > pageNumber => throw
        if (pageNumber < 1)
        {
            throw new ArgumentOutOfRangeException("invalid page number");
        }
        var enumerator = items.GetEnumerator();

        // reach the required page
        for (int i = 1; enumerator.MoveNext() && i < (pageNumber - 1) * pageSize ; i++) { }

        // print items of that page 
        for (int i = 1; i <= pageSize && enumerator.MoveNext(); i++)
        {
            yield return enumerator.Current.Value;
        }
    }


}
