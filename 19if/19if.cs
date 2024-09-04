namespace _19if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Test = 100;
            // 조건문이다.
            if (Test == 100) 
            {
                Console.WriteLine("Test는 100입니다.");
            }

            // 컨트롤 rr을 누르면 참조되는 변수까지 모두 변경 가능하다.
            int ElseIfTest = 10;

            if (ElseIfTest == 100)
            {
                Console.WriteLine("ElseIfTest는 100입니다.");
            }
            else if (ElseIfTest == 10) 
            {
                // 위에 조건과 연계되어
                // 위 조건이 false일 때 아래조건으로 들어온다.
                Console.WriteLine("ElseIfTest는 10입니다.");
            }

            int ElseTest = 5;
            if (ElseTest == 100)
            {
                Console.WriteLine("ElseTest는 100입니다.");
            }
            else if (ElseTest == 10)
            {
                Console.WriteLine("ElseTest는 10입니다.");
            }
            else
            {
                Console.WriteLine("연계된 모든 조건이 거짓이었습니다.");
            }
        }
    }
}
