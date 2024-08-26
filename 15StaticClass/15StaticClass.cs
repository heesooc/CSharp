// 정적 클래스란
// 정적 멤버변수와
// 정적 멤버함수만을 가질 수 있는 클래스이다.

static class StClass
{
    //일반 멤버변수 선언만 해도 오류가 난다.
    //int Test = 100;
}

namespace _15StaticClass
{
    internal class Program
    {
        static int Number = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
