using LaurianeCsharp.Lib;

namespace LaurianeCsharp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestMaMethode1()
        {
            string a = "test";
            string testt = "test" + "test";
            string testtt = $"test{a}"; // testtest
            int test2 = 1;
            bool test3 = true;
            byte test4 = 0x0F;
            char test10 = 'a';

            float test5 = 0.01f;
            double test6 = 0.01;
            decimal test7 = 0.01m;

            short test8 = 1;
            long test9 = 1;
            
            DateTime test11 = DateTime.UtcNow;
            DateTime test12 = new DateTime(2025,01,01);

            var aaaaa = new MyDiscoveringClass();
            var bbb = new MyDiscoveringClass("XXXX");
            // aaaaa.MyProperty = "test";
            
            MyDiscoveringClass.MyMethodeStatic();
            // bbb.MyMethodeStatic();
            var zdqd= MyDiscoveringClass.MY_CONSTANTE;
            
            var myStaticConstructor = MyStaticConstructorClass.Create("test");
            //var myStaticConstructor = new MyStaticConstructorClass("test");

            var myEnum = MyEnum.Val1;
            var myFlag = MyFlag.Val3 | MyFlag.Val2;
            
            var myList = new List<string>();
            List<string> myList2 = [];

            foreach (var xx in myList2)
            {
                // xx
            }
        }
    }
}

// - Génériques
//     - Interfaces - multiple
//     - Surcharge des méthodes
//     - Héritage + base
//     - Abstract / Virtual / Override / New / Sealed
//     - Exceptions + Try / Catch
//     - Condition, ternaire
//     - Nullable ?
//     - out
// - Extensions
//     - Async / Await / Thread / Task
//     - action et func
//     - Manipulation de string