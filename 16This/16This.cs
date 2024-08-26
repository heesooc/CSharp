class Player
{
    private int HP = 100;
    private static int StTest = 100;

    public void Damage(int _Dmg)
    {
        // c#은 대체 어떻게
        // 이 hp가 플레이어2의 
        // hp라는 걸 알 수 있을까?
        HP -= _Dmg;
        this.HP -= _Dmg;
    }

    public void Heal(/*Player this,*/ int _Heal)
    {
        // 멤버함수에서
        // 멤버변수를 쓴다면
        // 눈에 보이지는 않지만
        // 앞에 this.이 생략된 것이다.
        // this.HP라는 것을 잊으면은 안됨.
        HP += _Heal;
    }

   public static void Damage(Player _this, int _Dmg)
    {
        StTest += _Dmg;
        //HP = 1000; (X)
        // static 맴버함수는
        // 객체를 만들지 않고도 사용할 수 있으므로
        // 자신이라는 개념이 없는 함수이다.
        // this.HP; (X)
        _this.HP -= _Dmg;
        Console.WriteLine(StTest);
    }
}

namespace _16This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player NewPlayer3 = new Player();
           
            NewPlayer2.Damage(10);
            //NewPlayer2.Heal(NewPlayer2, 100);
            NewPlayer2.Heal(100);
            Player.Damage(NewPlayer1 , 20);
            
            
        }
    }
}
