using System;
public interface ITest1 { void Test(); }
public interface ITest2 { void Test(); }

public class TestClass : ITest1, ITest2
{
    void ITest1.Test() { Console.WriteLine("ITest1.Test"); }
    void ITest2.Test() { Console.WriteLine("ITest2.Test"); }
}

public class SAMPLE
{
    public static void Main(string[] args)
    {
        var testClass = new TestClass();
        ((ITest1)testClass).Test();  // Calls ITest1.Test
        ((ITest2)testClass).Test();

    }
}