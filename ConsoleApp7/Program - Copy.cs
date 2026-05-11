namespace ConsoleApp7
{
    // Moved all top-level statements into a Main method to resolve CS8802
    public class Program2
    {
        public static void Main()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            //aaaaa
        }
    }

    public class Program3
    {
        public void MyMethod()
        {
            ConsoleCancelEventHandler handler = (sender, e) =>
            {
                Console.WriteLine("Console cancel event triggered!");
                Console.WriteLine($"SpecialKey: {e.SpecialKey}");
                Console.WriteLine($"Cancel before: {e.Cancel}");

                // Prevent the application from exiting
                e.Cancel = true;

                Console.WriteLine($"Cancel after: {e.Cancel}");
                //1111
            };
        }
    }
}
