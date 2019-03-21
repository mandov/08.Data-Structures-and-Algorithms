namespace ReadPositiveIntegersFromColumn
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class ReadPositiveIntegersFromColumn
    {
        static void Main()
        {
            string number = Console.ReadLine();
            List<int> sequenceOfNumbers = new List<int>();

            while (!string.IsNullOrWhiteSpace(number))
            {
                sequenceOfNumbers.Add(int.Parse(number));
                number = Console.ReadLine();
            }

            int sumOfSequece = sequenceOfNumbers.Sum();
            double averageOfSequence = sequenceOfNumbers.Average();

            Console.WriteLine($"The sum of sequence is: {sumOfSequece}\nThe average result of sequence is: {averageOfSequence}");
        }
    }
}