// 코드 재활용성이 떨어진다는 표현을 사용하게 된다.
// 이 코드 재활용성을 향상시키기 위한 문법이.
// 상속이다.

// 클래스는 웬만하면 자기의 일은 스스로하자.
// 캡슐화(은닉)
// 멤버변수는 private인 상태로 해결을 봐라.

class FightUnit
{
    protected string Name = "None";
    int AT = 10;
    protected int HP = 50;
    public int MAXHP = 100;

    public void SetName(string _Name)
    {
        Name = _Name; 
    }

    public void StatusRender()
    {
        Console.WriteLine(Name);
        Console.WriteLine("---------------------------");
        Console.Write("공격력 : ");
        Console.WriteLine(AT);

        // 체력: 50/100
        Console.Write("체력 : ");
        Console.Write(HP);
        Console.Write("/");
        Console.WriteLine(MAXHP);
        Console.WriteLine("---------------------------");
    }
}

class Player : FightUnit
{
    public void Heal()
    {
        HP = MAXHP;
    }

    public int GetHP()
    {
        return HP;
    }

    public Player()
    {
        Name = "플레이어";
    }
}

class Monster : FightUnit
{
    // 인자값을 만들어줄 수도 있다.
    public Monster(string _Name)
    {
        Name = _Name;
    }
}

// 에러나 혹은 잘못된 선택에 관한 것도 만든다. 
enum STARTSELECT
{
    SELECTTOWN,
    SELECTBATTLE,
    NONESELECT,
}

namespace TextRpg001
{
    class Test
    {
        int Number(int _AAA)
        {
            return _AAA;
        }
    }

    internal class TextRpg001
    {
        // 시작한다. 
        // 마을로 갈지 싸움터로 갈지를 정해주는 함수.
        static STARTSELECT StartSelect()
        {
            // 분명히 있다.
            // 없을리가 없다.
            // 내가 못찾으면 내가 능력이 부족한거다.
            // 나는 콘솔 화면을 모조리 지우는 함수를 찾고 싶다.
            
            // 프로그래머들은 대부분 이성적이고
            // 이름을 엉망x
            // 
            Console.Clear();
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 배틀");
            Console.WriteLine("어디로 가시겠습니까?");
            // 리턴이란 구문은 리턴이 되는순간
            // 함수를 완전히 종료시킨다. 
            // 즉 리턴을 한 번 했다면 그 아래
            // 아무리 많은 코드가 있어도.
            // 사용이 없다.
            ConsoleKeyInfo CKI = Console.ReadKey();

            Console.WriteLine("");

            switch (CKI.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("마을로 이동합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.D2:
                    Console.WriteLine("배틀을 시작합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    Console.ReadKey();
                    return STARTSELECT.NONESELECT;
            }
        }
        static void Town(Player _Player)
        {
            while (true) 
            {
                Console.Clear();
                _Player.StatusRender();
                Console.WriteLine("마을에서 무슨 일을 하시겠습니까?");
                Console.WriteLine("1. 체력을 회복한다.");
                Console.WriteLine("2. 무기를 강화한다.");
                Console.WriteLine("3. 마을을 나간다.");

                // 초반에 프로그래밍의 전부.
                // 객체(클래스)를 선언해야할 때
                // 함수의 분기
                // 함수의 합칠 때와 쪼갤 때.

                // ConsoleKey CK = Console.ReadKey().Key;
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        // 이 안의 내용을 채우면 됩니다.
                        // _Player.HP = _Player.MAXHP;
                        _Player.Heal();
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        return;
                }
            }
        }

        static void Battle(Player _Player)
        {
            // Console.WriteLine("아직 개장하지 않았습니다.");
            // Console.ReadKey();

            Monster NewMonster = new Monster("오크");

            while (/*둘 중 누군가 죽을 때까지*/true)
            {
                Console.Clear();
                _Player.StatusRender();
                NewMonster.StatusRender();
                // 실력 늘고 싶다.
                // 1. 죽을 때까지 싸우게 만들어라.
                // 1-1. 권장. 플레이어 한 대. 몬스터 한 대.
                // 2. 한 쪽이 죽으면(나간다) 마을로 자동이송.
                // 2-1. 그냥 나간다.
                // 2-2. 마을로 나간다. 
                // 가장 기본적인 것이 되면
                // 그 다음부터 하세요. 
                // 가장 단순한 부분부터 만들어가라.
                // 싸우게 만들어보세요. 
                Console.ReadKey();
            }
        }

        static int TenReturn()
        {
            return 10;
        }

        static void Main(string[] args)
        {
            // 객체지향 프로그래밍이란
            // 결국. 클래스로 설계하고
            // 객체로 만들어 나가는 것.

            // int Number = TenReturn();
            // 저는 마을과 싸움터로 나눠서
            // 입장하게 하고 싶다면
            // 반복문과 조건문 중 

            // 첫번째 static
            // 
            Player NewPlayer = new Player();
            //NewPlayer.SetName("플레이어");

            /* while (true) 
             {
                 // 객체화하지 않고도
                 // 쓸 수 있는 함수
                 // static 함수 
                 // 정적맴버변수
                 ConsoleKeyInfo KeyInfo = Console.ReadKey();
                 // 반환. 리턴값
                 Console.WriteLine(KeyInfo.Key);
             }*/ 

            while (true)
            {
                // 함수 자체의 용도를 생각해라
                // 정말 한 가지의 용도로만 사용할 수 있나?
                STARTSELECT SelectCheck = StartSelect();

                switch (SelectCheck)
                {
                    case STARTSELECT.SELECTTOWN:
                        Town(NewPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        Battle(NewPlayer);
                        break;
                }
            }
        }
    }
}
