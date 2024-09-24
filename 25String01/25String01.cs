// 언어는 숨쉬는 것.
// 붉은 줄이 갔다. 왜 안되지?

// 프로그래밍에 있어서
// 제가 기본기라고 생각하는 것이 3가지가 있다.
// 디버깅 (중단점) 95% 정도 된다.
// 문자열 // 3%
// 파일입출력 // 2%


namespace _25String01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 자료형이 다르면 C#은 대입할 수 없다.
            // int a 크기 4바이트
            // 동적 기본자료형이다.
            // 문자
            char Charactor = 'a';
            // string은 char의 집합
            string TEST = "aaaa";

            // 자료형은 C#에서 만들어놓은 기본구조체이다.
            int AAA = new int();
            AAA = 100;
            TEST = AAA.ToString();
            // string int.ToString() -> string은 리턴값
            Console.WriteLine(TEST);

            // int는 구조체이고 내부의 맴버변수나 함수가 존재하고
            // 그것을 통해서 문자열로 변환을 해줄 수 있다.

            string Left = "안녕하세요";
            string Right = " 날씨가 좋네요";
            string Result = Left + Right+ AAA.ToString();

            Console.WriteLine(Result);
          

            if (Charactor == 'a') 
            {
            }
        }
    }
}
