namespace AbstractClass;

public abstract class AbstractStorage
{
    //abstract method for storing data
    public abstract void StoreData(string key, object value);

    //abstract method for fetching data
    public abstract object FetchData(string key);
}


public class CacheStorage : AbstractStorage
{
    private Dictionary<string,object> Caches { get; set; } = new Dictionary<string,object>();
    public override object FetchData(string key)
    {
        if(Caches.ContainsKey(key))
            return Caches[key];
        return "Does not exist key !";
    }

    public override void StoreData(string key, object value)
    {
        Caches[key] = value;
    }
}


public class DatabaseStorage : AbstractStorage
{
    private Dictionary<string, object> Database { get; set; } = new Dictionary<string, object>();
    public override object FetchData(string key)
    {
        if (Database.ContainsKey(key))
            return Database[key];
        return "Does not exist key !";
    }

    public override void StoreData(string key, object value)
    {
        Database[key] = value;
    }
}