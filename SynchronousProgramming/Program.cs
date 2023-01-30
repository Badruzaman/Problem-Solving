
LongProcess();
ShortProcess();

Console.ReadKey();

static void LongProcess()
{
    Console.WriteLine("LongProcess Started");
   
    System.Threading.Thread.Sleep(4000); // hold execution for 4 seconds
    Console.WriteLine("LongProcess Completed");
}

static void ShortProcess()
{
    Console.WriteLine("ShortProcess Started");
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("ShortProcess Completed");
}