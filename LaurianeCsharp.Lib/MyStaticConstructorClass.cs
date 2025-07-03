namespace LaurianeCsharp.Lib;

public class MyStaticConstructorClass
{
    private readonly string _xxx;
    public string Uuid { get; }
    
    private MyStaticConstructorClass(string uuid)
    {
        Uuid = uuid;
        _xxx = "test";
    }
    
    public static MyStaticConstructorClass Create(string uuid)
    {
        if (uuid.Length != 64)
            throw new Exception("UUID invalide");
        return new MyStaticConstructorClass(uuid);
    }
    
    // De la base de données
    public static MyStaticConstructorClass Restore(string uuid)
    {
        return new MyStaticConstructorClass(uuid);
    }
}