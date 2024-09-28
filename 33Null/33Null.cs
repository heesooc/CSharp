
class Player
{
    int mAT;

    public int AT { get { return mAT; } set { mAT = value; } }
}

class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        // 가리키는게 없이 비워놓겠다.
        // 참조형의 데이터 구조를 가지는 자료형들은
        // 클래스는
        // new를 하게 되면
        // 힙에 본체 생김
        Player NewPlayer2 = null;

        Console.WriteLine(NewPlayer.AT);
        Console.WriteLine(NewPlayer2.AT);

    }  
}

