namespace staging_challenges;

public class Challenges
{
    static void Main()
    {
        var test = new SecondMax();

        var variable = new string[]{"3", "1 2 3", "10 15 5", "100 999 500"};

        test.Solution(variable);


        var nextTest = new SumInString();

        var nextVar = new string[] { "1", "ab1231da" };

        nextTest.Solution(nextVar);
    }
}