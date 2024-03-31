namespace DAL.Interfaces;

public abstract class GenericRepository<T> : IRepository<T> where T : class
{
    protected readonly DataContext _dataContext;

    public GenericRepository()
    {
        _dataContext = new DataContext();
    }

    public void Add(T item)
    {
        _dataContext.Set<T>().Add(item);
        _dataContext.SaveChanges();
    }

    public virtual List<T> GetAll()
    {
        return _dataContext.Set<T>().ToList();
    }

    public void Remove(int id)
    {
        T item = _dataContext.Set<T>().Find(id) ??
            throw new ArgumentNullException();

        _dataContext.Set<T>().Remove(item);
        _dataContext.SaveChanges();
    }

    public void Update(T item, int id)
    {
        T oldItem = _dataContext.Set<T>().Find(id) ??
            throw new ArgumentNullException();

        oldItem = item;
        _dataContext.SaveChanges();
    }
}
