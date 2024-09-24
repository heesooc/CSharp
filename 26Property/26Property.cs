class Player
{
    public int HP = 20;

    // 보통 어떤 맴버변수가 이런 타겟이다.

    int AT = 10;

    // 자료형을 선언했다면 이는 int와 관련된 함수라고
    // 명시하는 것.
    public int ProAT
    {
        // 프로퍼티의 GET 함수는 무조건 int를
        // 리턴한다고 보고
        get
        {
            if (999 < AT)
            {
                Console.WriteLine("최대 수정치를 넘겼습니다.");

            }
            return AT;
        }

        // 무조건 int하나가 들어온다고 생각한다.
        // 그런 외부 값들을 프로퍼티에서는
        // value라고 기호로 정의해놨다.
        /*set
        {
            AT = value;
        }*/
    }
   
    public int GetAT() 
    {
        if (999 < AT)
        {
            Console.WriteLine("최대 수정치를 넘겼습니다.");
            while (true) { Console.ReadKey(); }
        }

        return AT; 
    }

    public void SetAT(int _Value)
    {
        // public으로 할 때와 다른 점은 디버깅과 제한 가능
        if (999 < _Value)
        {
            Console.WriteLine("최대 수정치를 넘겼습니다.");
            while (true) {Console.ReadKey(); }
        }
        
        AT = _Value;
    }
}

namespace _26Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            NewPlayer.HP = 80;
            // 대봤을 때 프로퍼티는 getset 뜸
            //NewPlayer.ProAT = 100;
            int PlayerAT = NewPlayer.ProAT;

            //NewPlayer.SetAT(999999);
        }
    }
}
