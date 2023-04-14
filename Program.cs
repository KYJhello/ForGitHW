namespace ForGitHW
{
    internal class Program
    {
        // 1. 문자열 속에 문자 찾기
        static void Test1()
        {
            string input = "pineapple is yummy";
            string findStr = "apple";
            Console.WriteLine(input.IndexOf(findStr));
        }
        
        static void Main(string[] args)
        {
            // 1. 문자열 속에 문자 찾기
            Test1();
        }
    }
}