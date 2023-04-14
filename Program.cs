namespace ForGitHW
{
    internal class Program
    {
        // 문자열 속에 문자 찾기
        static void Main(string[] args)
        {
            string input = "pineapple is yummy";
            string findStr = "apple";
            Console.WriteLine(input.IndexOf(findStr));
        }
    }
}