namespace _20Switch
{
    internal class Program
    {
        static int Number()
        {
            return 100;
        }

        static void Main(string[] args)
        {
            int Left = 50;
            int Right = 10;

            if (Number() == 50)
            {

            }

            switch (Left > Right)
            {
                case true:
                    Console.WriteLine("Left > Right은 참입니다.");
                    break;
                case false:
                    Console.WriteLine("Left > Right은 거짓입니다.");
                    break;
            }

            // 이녀석은 == 연산밖에 못합니다.

            int Test1 = 50;
            int SwitchTest = 0;

            switch (SwitchTest)
            {
                // case Test1: // 변수는 안됩니다.
                // 오로지 상수와만 비교할 수 있다. 
                //    break;
                case 0:
                case 1:
                    Console.WriteLine("SwitchTest는 0 또는 1입니다.");
                    break;
                case 100:
                    Console.WriteLine("SwitchTest는 100입니다.");
                    break;

                default: // else의 역할을 한다.
                    Console.WriteLine("모든 조건이 맞지 않습니다.");
                    break;
            }
        }
    }
}
