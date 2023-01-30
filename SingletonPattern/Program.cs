// See https://aka.ms/new-console-template for more information

using SingletonPattern;

var singleton = Singleton.GetInstance();

var singleton2 = Singleton.GetInstance();

//if (singleton == singleton2)
//{
//    Console.WriteLine("Same instance");
//}
//else
//{
//    Console.WriteLine("Not the same");
//}


// thread safe test

var tasks = new Task[100];
for (int i = 0; i < tasks.Length; i++)
{
    tasks[i] = Task.Run(() => Singleton.GetInstance());
}

// we should only see "Im a singleton" once
await Task.WhenAll(tasks);
