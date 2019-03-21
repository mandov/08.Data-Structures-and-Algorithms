namespace ReverseIntegers
{
    using System;
    using System.Collections.Generic;

    public class ReverseIntegers
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            Stack<int> numbers = new Stack<int>();

            while (!string.IsNullOrWhiteSpace(number))
            {
                numbers.Push(int.Parse(number));
                number = Console.ReadLine();
            }
        
            while (numbers.Count != 0)
            {
                Console.WriteLine(numbers.Pop());
            }
        }
    }
}