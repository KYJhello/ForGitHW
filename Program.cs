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
        static void Test2()
        {
            string input = "안녕하세요. 나는 서울에 사는 홍길동이라고 합니다.";

            

        }

        // 3. 주어진 숫자가 소수인지 판별하는 solution을 완성하라.

        // 4. 사용자가 입력한 양의 정수의 각 자리수의 합을 구하는 Solution을 완성하라.

        // 5. k개의 정렬된 배열에서 공통항목을 찾는 Solution을 완성하라. 단, 중복은 허용하지 않는다.
        static int[] FindCommonItems(params int[][] arr)
        {
            // 첫 배열을 받음
            int[] answer = new int[arr[0].Length];

            foreach(int[] i in arr)
            {
                // 새로운 배열마다 중복 갯수 체크용 
                

                // i 배열의 int j요소를 받음
                foreach (int j in i)
                {
                    answer.Contains(j);
                    //// j와 answer의 요소 k의 중복체크 
                    //foreach (int k in answer)
                    //{
                    //    if(k == j)
                    //    {
                    //        // 배열 i[]와 temp[]의 구성요소를 비교하여 중복요소 있을 시
                            
                    //    }

                    //}
                }
            }


            return answer;
        }
        static void Test5()
        {
            int[] arr1 = { 1, 5, 5, 10 };
            int[] arr2 = { 3, 4, 5, 5, 10 };
            int[] arr3 = { 5, 5, 10, 20 };

            int[] ansArr =  FindCommonItems(arr1, arr2, arr3);

            foreach (int i in ansArr)
            {
                Console.WriteLine(i);
            }
        }


        static void Main(string[] args)
        {
            // 1. 문자열 속에 문자 찾기
            Test1();
        }
    }
}