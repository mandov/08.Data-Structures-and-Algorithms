namespace LongestSubsequence
{
    using System;
    using System.Collections.Generic;

    public class LongestSubsequence
    {
        public static void Main()
        {
            List<int> sequenceOfNumbers = new List<int>
            {
                4, 8, 1, 4, 10, 10, 10, 10, 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 16, 5
            };

            List<int> longestEqualSubsequence = GetLongestEqualSubsequence(sequenceOfNumbers);

            longestEqualSubsequence.ForEach(n => Console.Write(n + " "));
        }

        public static List<int> GetLongestEqualSubsequence(List<int> sequenceOfNumbers)
        {
            List<int> subsequence = new List<int>();
            int currentSubsequence = 1;
            int bestSubsequence = 0;

            for (int i = 0; i < sequenceOfNumbers.Count - 1; i++)
            {
                for (int j = 1; j < sequenceOfNumbers.Count; j++)
                {
                    if (sequenceOfNumbers[j - 1] == sequenceOfNumbers[j])
                    {
                        currentSubsequence++;
                        if (currentSubsequence > bestSubsequence)
                        {
                            bestSubsequence = currentSubsequence;
                            subsequence.Clear();
                            subsequence.AddRange(sequenceOfNumbers.GetRange(j - (bestSubsequence - 1), bestSubsequence));
                        }
                    }
                    else
                    {
                        currentSubsequence = 1;
                    }
                }
            }

            return subsequence;
        }
    }
}