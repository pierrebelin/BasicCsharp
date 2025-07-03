namespace LaurianeCsharp.Lib;

public class MyDiscoveringClass
{
    // const = static + non modifiable
    public static string MY_CONSTANTE = "JESUISUNECONSTANTE"; // "JESUISUNECONSTANTE"
    private readonly string _myAttribute; // Par sensé être exposé
    
    // private string _myProperty; // Par sensé être exposé
    // public string MyProperty
    // {
    //     get
    //     {
    //         return _myProperty;
    //     }
    //     set
    //     {
    //         _myProperty = value;
    //     }
    // }
    // Identique à au dessus
    // public string MyProperty { get; private set;  } // Exposé
    public string MyProperty { get; private set;  } // Exposé

    // Constructeur
    public MyDiscoveringClass(string myAttribute)
    {
        MyProperty = "test";
        _myAttribute = myAttribute;
    }
    
    public MyDiscoveringClass()
    {
        MyProperty = "test";
        _myAttribute = "X";
    }

    // Portée : public (partout), private (scope restreint à la portée), protected (restreint à l'héritage), internal (restreint au projet)

    public List<string> MyList = [];
    // public List<string> MyList = new();
    // public List<string> MyList = new List<string>();
    public string[] MyArray = [];
    // public string[] MyArray = new string[10];
    public Dictionary<string, string> MyDictionary = new();
    
    public string MyMethode(string x = "test")
    {
        // string myAttribute = "test";
        // _myAttribute = "test";
        var myAttribute = x;
        return "test";
    }

    public void MyMethodeWithReturn()
    {
    }

    public static MyDiscoveringClass Create()
    {
        return new MyDiscoveringClass();
    }
    
    public static void MyMethodeStatic()
    {
        MyStaticClass.MyStaticMethod();
        // NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOON
        // _myAttribute = 1;
        // this._myAttribute;
    }
    
    public (string, string) MyMethodeWithTuple()
    {
        return ("test", "test");
    }
    
    public MyRecord MyMethodeWithRecord()
    {
        return new MyRecord("test", "test");
    }
}

public record MyRecord(string MyProperty, string MyPropert2);