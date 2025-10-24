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
            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }
        public void Method2()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            // Using the new LINQ method introduced in C# 10
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));
            Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine);
            

        }

    }
}
