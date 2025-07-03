namespace LaurianeCsharp.Lib;

public interface IMyInheritanceInterface
{
    void MyMethod();
}

public interface IMyInheritanceInterface3
{
    void MyMethod3();
}

public abstract class Card : IMyInheritanceInterface, IMyInheritanceInterface3
{
    public string MyProperty { get; set; }
    public void MyMethod()
    {
        throw new NotImplementedException();
    }

    protected Card(string val)
    {
        MyProperty = val;
    }
    
    // Pas de body
    protected abstract void MyMethod2();

    // Un body
    public virtual void MyMethod3()
    {
        // if (MyMethod2() != false)
        //     throw new NotImplementedException();
    }
}

public class VCard : Card
{
    public VCard() : base("test")
    {
        
    }
    
    protected override void MyMethod2()
    {
        throw new NotImplementedException();
    }
}

public class VConf : Card
{
    public VConf() : base("vconf")
    {
        
    }
    
    protected override void MyMethod2()
    {
        throw new NotImplementedException();
    }
    
    public override void MyMethod3()
    {
        base.MyMethod3();
        // XXXXXXXXX
    }
}

public class V
{
    public static void Aa()
    {
        // var a = new Card();
        
        var v = new VCard();
        // v.MyProperty;
        v.MyMethod();
        v.MyMethod3();
        var vv = new VConf();
        vv.MyMethod();
    }
}


// - Génériques
//     - Surcharge des méthodes
//     - Abstract / Virtual / Override / New / Sealed
//     - Exceptions + Try / Catch
//     - Condition, ternaire
//     - Nullable ?
//     - out