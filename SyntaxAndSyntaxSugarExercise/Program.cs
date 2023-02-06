namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ans = 4;
            var response = (ans < 9) ? $"{ans} is less than 9" : $"{ans} is greater than or equal to 9";
            Console.WriteLine(response);
        }
    }
}
