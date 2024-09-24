class FightUnit
{
    protected int AT;

    public FightUnit()
    {
        int a = 0;
    }
}

class Player : FightUnit
{
    // 생성자라고 합니다.
    // 특징
    // 리턴값이 없어요.
    // 생성자란
    // 만들어질 때 한 번 실행되어주는 함수.

    // 눈에 보이지 않지만 만들지 않아도 이 함수는 만들어진다.
    // 무조건 자신의 클래스의 메모리를 리턴해주는 함수이다.
    public Player()
    {
        AT = 100;

        int Number = 0; 
    }
}

namespace _24ClassConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // private이라면 만들 수 없음 -> 의미가 있다.
            Player NewPlayer = new Player();    
        }
    }
}
