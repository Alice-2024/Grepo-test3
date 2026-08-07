namespace ConsoleApp7
{
    // Moved all top-level statements into a Main method to resolve CS8802
    public class Program2
    {
        public static void Main()
        {
            Console.WriteLine("Hello, World!");//AAAAA
            Console.WriteLine("Hello, World!");//BBBB
            Console.WriteLine("Hello, World!");//11111
            Console.WriteLine("Hello, World!");//22222
            Console.WriteLine("Hello, World!");
        }
    }

    public class Program3
    {
        public void MyMethod()
        {
            char myChar = 'A';
            Console.WriteLine("Hello, World!");//AAAA
            Console.WriteLine("Hello");
            Console.WriteLine("test1");
            Console.WriteLine("test2");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            //a new comment in the middle of the code
            //11111111111
            //BBB
            //CCC
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            //test auto resolve merge conflict
            //test auto resolve merge conflict
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
        }
    }
}
