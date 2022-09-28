namespace staging_challenges;

public class Challenges
{
    static void Main()
    {
        var test = new LargestGap();

        var variable = new int[]{ 14, 13, 7, 1, 4, 12, 3, 7, 7, 12, 11, 5, 7 };

        test.Solution(variable);
    }
}