
//Method();
Main();
Console.ReadKey();

// Basic Asynchronous Method
async Task Method()
{
    Console.WriteLine("Start");
    await DoAsyncWork();
    Console.WriteLine("End");
}
async Task DoAsyncWork()
{
    await Task.Delay(3000); // Simulate a non-blocking delay for 2 seconds
    Console.WriteLine("Async work complete");
}
// Parallel Asynchronous Tasks
async Task Main()
{
    Console.WriteLine("Start");
    Task task1 = getTask("task1");
    Task task2 = getTask("task2");
    Task task3 = getTask("task3");
    await Task.WhenAll(task1, task2, task3);
    Console.WriteLine("End");
}
async Task getTask(string taskName)
{
    await Task.Delay(2000);
    Console.WriteLine($"task completed {taskName}");
}