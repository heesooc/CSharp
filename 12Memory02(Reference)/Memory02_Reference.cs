class Monster()
{
    int AT = 10;
    public int HP = 100;

    public void Att(Player _Player)
    {
        _Player.HP -= AT;
    }
}

class Player()
{
    int AT = 10;
    public int HP = 100;

    void Att(Monster _Monster)
    {
       _Monster.HP -= AT;
    }
}


namespace _12Memory02_Reference_
{
    internal class Memory02_Reference
    {
        static void Main(string[] args)
        {
            // 값형과 레퍼런스 형을 구분할 줄 알아야한다.(괄호안)
            // 기본 자료형을 선언만 하면 그녀석들은 값형이다.

            // 클래스가 객체화된 녀석은
            // 레퍼런스 형이라고 하고
            // 여태까지 봐왔던
            // int bool 이런 녀석들은
            // 값형이라고 한다. 

            // 이 값형과 레퍼런스형은
            // 메모리의 위치와 사용법이 다르기 때문에
            // 다르게 동작한다. 

            Monster NewMonster = new Monster();
            Player NewPlayer = new Player();
            // 힙에 실제 만들어진: new Player(), new Monster()
            // 이 레퍼런스라고 하는 녀석은
            // 힙에 생성된 어떠한 메모리의 위치를 가리키는
            // 값이다. (앞에 부분)

            // 'NewPlayer.' 정확한 이해:
            // 내가 가리키고 있는
            // 위치에 있는 HP를 사용하겠다. 
            NewMonster.Att(NewPlayer);
            Console.WriteLine(NewPlayer.HP);
        }
    }
}


