namespace asynchronous
{
    public class program
    {

        static void Main()
        {
            System.Console.WriteLine(">> Start");
            performOperation("Task1", 2000);
            performOperation("Task2", 3000);
            System.Console.WriteLine("<< End");
        }

        static void performOperation(string taskName, int delayDuration)
        {
            System.Console.WriteLine($"{taskName} started.");
            Thread.Sleep(delayDuration);
            System.Console.WriteLine($"{taskName} finished.");
        }
    }
}