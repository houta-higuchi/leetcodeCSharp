
using System;
public abstract class RunExample : Runnable
{
    public abstract void Run();

    public void RunInTime() {
        DateTime start = DateTime.Now;
        Run();
        double m = (DateTime.Now - start).TotalMilliseconds;
        Console.Write("算法耗时" + m + "ms");
    }
}