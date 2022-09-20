namespace staging_challenges;

// Write a program that accepts sets of three numbers and prints the second-maximum number among the three.

// Input
// First line contains the number of triples, N.
// The next N lines which follow each have three space separated integers.

// Sample Input
// 3
// 1 2 3
// 10 15 5
// 100 999 500
// Sample Output
// 2
// 10
// 500

public class SecondMax
{
    public void Solution(string[] input)
    {
        int n = Int32.Parse(input[0]);
        List<int[]> nums = new List<int[]>();

        for(int i = 1; i <= n; i++)
        {
            string[] split = input[i].Split(" ");

            int[] parsedItems = new int[3];

            int count = 0;
            foreach(string item in split)
            {
                parsedItems[count] = Int32.Parse(item);
                count++;
            }

            nums.Add(parsedItems);
        }

        foreach (int[] item in nums)
        {
            Array.Sort(item);
            Console.WriteLine(item[1]);
        }
    }
}