namespace LaurianeCsharp.Lib;

public interface IMyInterface
{
    string MyProperty { get; set; } // JAMAIS !
    void MyMethod();
}

public class MyClass : IMyInterface
{
    public string MyProperty { get; set; }

    public void MyMethod()
    {
        throw new NotImplementedException();
    }
}
