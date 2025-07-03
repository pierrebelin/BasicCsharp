using System.Text.Json;

namespace LaurianeCsharp.Tests;

public class UnitTest2
{
    [Fact]
    public void TestMaMethode1()
    {
        var list = new List<ICard>
        {
            new VCard(),
            new VConf()
        };

        foreach (ICard card in list)
        {
            card.MyMethod();
            
            if (card.GetType() == typeof(VCard))
            {
                ((VCard)card).AA();
            }
            // EGAUX
            if (card is VCard vcard)
                vcard.AA();
            
            else if (card is VConf vconf)
                vconf.BB();
            
            card.MyGeneric();
        }


        var aaaa = "xxxx";
        JsonSerializer.Deserialize<MyClass>(aaaa);

    }
    
}

public static class MyClassExtensions2
{
    public static void MyGeneric<T>(this T myClass) where T : ICard
    {
        //
        myClass.MyMethod();
        //
    }
}

public class VCard : ICard
{
    public void MyMethod()
    {
        throw new NotImplementedException();
    }
    public void AA()
    {
        throw new NotImplementedException();
    }
}

public class VConf : ICard
{
    public void MyMethod()
    {
        throw new NotImplementedException();
    }
    public void BB()
    {
        throw new NotImplementedException();
    }
}

public interface ICard
{
    void MyMethod();
}