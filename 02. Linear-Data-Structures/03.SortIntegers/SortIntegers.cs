namespace SortIntegers
{
    using System;
    using System.Collections.Generic;

    public class SortIntegers
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            List<int> numbers = new List<int>();

            while (!string.IsNullOrWhiteSpace(number))
            {
                numbers.Add(int.Parse(number));
                number = Console.ReadLine();
            }

            int tmp = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i; j < numbers.Count; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        tmp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = tmp;
                    }
                }
            }

            foreach (var numberFromList in numbers)
            {
                Console.WriteLine(numberFromList);
            }
        }
    }
}