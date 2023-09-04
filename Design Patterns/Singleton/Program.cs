using Singleton.BaseExample;
using Singleton.LazyExample;
using Singleton.ThreadSafe;

BaseExample();
ThreadSafeExample();
LazyExample();

static void BaseExample()
{
    BaseExampleSingleton s1 = BaseExampleSingleton.GetInstance();
    BaseExampleSingleton s2 = BaseExampleSingleton.GetInstance();

    if (s1 == s2)
    {
        Console.WriteLine("Singleton works, both variables contain the same instance.");
    }
    else
    {
        Console.WriteLine("Singleton failed, variables contain differente instances.");
    }
}

static void ThreadSafeExample()
{
    Console.WriteLine(
        "{0}\n{1}\n\n{2}\n",
        "If you see the same value, then singleton was reused (yay!)",
        "If you see different values, then 2 singletons were created (booo!!)",
        "RESULT:"
    );

    Thread process1 = new(() =>
    {
        var singleton = ThreadSafeSingleton.GetInstance("Foo");
        Console.WriteLine(singleton.Value);
    });

    Thread process2 = new(() =>
    {
        var singleton = ThreadSafeSingleton.GetInstance("Bar");
        Console.WriteLine(singleton.Value);
    });

    process1.Start();
    process2.Start();

    process1.Join();
    process2.Join();
}

static void LazyExample()
{
    Thread process1 = new(() =>
    {
        var singleton = LazySingleton.Instance;
        Console.WriteLine(singleton.GetStringValue("Foo"));
    });

    Thread process2 = new(() =>
    {
        var singleton = LazySingleton.Instance;
        Console.WriteLine(singleton.GetStringValue("Bar"));
    });

    process1.Start();
    process2.Start();

    process1.Join();
    process2.Join();
}