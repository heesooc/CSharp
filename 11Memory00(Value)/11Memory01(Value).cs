
class Player
{
    public int Test(int _Dmg)
    {
        // 이 안에 지역변수에서 벌어지는 일은
        // 이 안에서 벌어지는 일일 뿐이다. 
        _Dmg = 8884;
        // 해결법(main함수것까지해야):
        return _Dmg;
    }
}
class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

        int Value = 0;
        NewPlayer.Test(Value);
        Console.WriteLine(Value);

        // 보통 2가지로 나뉜다. 
        // 0이다.
        // 1000이다. -> 이걸 말한다.
        // 왜냐 아직 메모리를 이해하지 못했다.
        // 데이터의 흐름을 이해하고 있지 못하다. 
        // 이걸 이해하려면
        // 값과 위치*에 대해서 

        // 지금까지 배운 문법으로는 절대로 불가능하다.
        // 그러면 어떻게 해야 하느냐?
        // 값형의 처리.
        Value = NewPlayer.Test(Value);
        Console.WriteLine(Value);
    }
    }

