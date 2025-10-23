namespace ConsoleApp7
{
    internal class Class1
    {
        public void Method1()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            // Using the new LINQ method introduced in C# 10
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));
            Console.WriteLine();
        }
        public void Method2()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            // Using the new LINQ method introduced in C# 10
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            //111111111
            //AAAAAAAAAAA
        }

    }
}
