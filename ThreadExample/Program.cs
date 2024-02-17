

Thread t1 = new Thread(method1);
t1.Name = "thread 1";
t1.Start();

Thread t2 = new Thread(method2);
t2.Name = "thread 2";
t2.Start();

Thread t3 = new Thread(method3);
t3.Name = "thread 3";
t3.Start();

Console.ReadKey();
void method1()
{
    Console.WriteLine("First thread");
}
void method2()
{
    Console.WriteLine("First thread");
}
void method3()
{
    Console.WriteLine("First thread");
}