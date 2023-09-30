using _003_ThreadsExample;

Console.WriteLine("Primary thread {0}", Thread.CurrentThread.GetHashCode());

ThreadClass.WriteChar('1', 80, ConsoleColor.Green);

var thread = new Thread(ThreadClass.Method2);

thread.Start();
thread.Join();

ThreadClass.WriteChar('1', 80, ConsoleColor.Green);

Console.WriteLine("Primary finished");
