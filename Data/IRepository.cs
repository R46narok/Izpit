namespace Data;

public interface IRepository<T, K>
{
    void Create(T item);
    T Read(K key);
    IEnumerable<T> ReadAll();
    void Update(T item);
    void Delete(K key);
}