class Player
{
    static public void PVP(Player _Left, Player _Right)
    {
        _Left.HP -= _Right.AT;
        _Right.HP -= _Left.AT;
    }

    private int AT = 100;
    private int HP = 100;
}

namespace _14StaticFunc
{   
    internal class Program
    {
        static void Main(string[] args) // 클래스에 속한 정적멤버함수
        {
            Console.WriteLine("static 함수 배우고 있어요");
            // WriteLine은 정적멤버함수. 왜냐면 클래스.으로 쓰고있으니까. 객체화 안함.
            // F12 누르면 정의로 이동. 
            
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player.PVP(NewPlayer1, NewPlayer2);

        }
    }
}
