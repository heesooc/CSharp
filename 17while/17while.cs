namespace _17while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비쥬얼스튜디오를 왜쓰냐?
            // 편하려고
            // 덜치려고
            // 빠르게 사용하려고.

            // 어떤 함수내에서
            // bool 값이 들어가면 된다.
            // while (참/거짓)
            bool Check = true;
            // 조건문 -> 실행코드 -> 조건문 -> 실행코드 -> 조건문
            // 조건문(true) -> 실행코드 -> 조건문(false)-> 빠져나왔다.
            while (Check)
            {
                Console.WriteLine("무한반복");
                Check = false;
            }

            // 실행코드 -> 조건문 -> 실행코드 -> 조건문 -> 실행코드
            // 한 번은 무조건 실행됨
            Check = false;
            do
            {
                Console.WriteLine("무한반복");
            } while (Check);

            // while문은 쓸 때
            // 항상 빠져나올 수 있는
            // 일반적인 프로그램에서는
            // 조건을 넣어놓고 실행해줘야 한다.

            // 상수를 넣어주면
            int Count = 0;
            do
            {
                Console.WriteLine(Count);
                Count++;
            } while (Count < 100);

            Count = 0;
            while (Count < 5)
            {
                Console.WriteLine(Count);
                Count++;
            }
            // F10누르면 값 어떻게 변하는지 다 알 수 있음 활용하기
        }
    }
}
