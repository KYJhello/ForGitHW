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

        // 2. 문자열을 입력받으면 단어의 갯수를 출력하기
        

        static void Main(string[] args)
        {
            // 1. 문자열 속에 문자 찾기
            Test1();
        }
    }
}