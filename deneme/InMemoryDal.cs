public class InMemoryDal<T> where T : class
{
    private List<T> _data;

    public InMemoryDal()
    {
        _data = new List<T>();
    }

    public List<T> GetAll()
    {
        return _data;
    }

    public void Add(T item)
    {
        _data.Add(item);
    }

}
