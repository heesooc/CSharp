namespace _34BreakContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // continue와 
            // break는 가장 가까운 반복문의 for(증감문) while(조건문)
            // 으로 이동한다.

            for (int i = 0; i < 100; i++)
            {
                if (0 == i % 2)
                {
                    // 만약 이 문장을 만나면
                    // while문에도 통한다.
                    // 반복문의 증감문으로 바로 이동한다.
                    continue;
                }

                Console.WriteLine(i);
            }
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (i == 50)
                    {
                        break;
                    }
                    Console.WriteLine(i);
                }
            }
               
        }
    }
}
