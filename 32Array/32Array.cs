namespace _32Array
{
    internal class Program
    {
        class Item
        {
            public string Name;
            public int AT;
            public int DF;
        }

        static void Main(string[] args)
        {
            // 배열은 기본적으로 자료형이라고 할 수 있으며
            // 기본자료형에 속한다.
            // 선언 방식은 어떤 자료형[]

            // 모든 자료형은 구조체 아니면 클래스에 가까운데.
            // 기본자료형도 마찬가지라고 표현했다.

            // [0][0][0][0][0][0][0][0][0][0]
            // int가 10개 생겼다.
            int[] ArrInt = new int[10];
            float[] ArrFloat = new float[10];

            // ArrInt는 int의 배열형(int의 집합)
            // ArrInt[0]은 무슨 자료형인가?

            // c#에서는 모든 자료형은 클래스 혹은
            // 구조체에 가깝다.
            // 맴버변수와 맴버 함수가 있다.

            // 여러 개가 모여있는 것.
            // 연속되어 있다.
            // 접근방법 그 모여있는 자료들을 접근하는 방법
            for (int i = 0; i < ArrInt.Length; i++) 
            {
                Console.WriteLine(ArrInt[i]);
            }
            // 배열을 언제 사용하느냐?
            // 아이템 100개 있다.

            // class 사용자 정의 자료형(참조형)
            // 아이템이라는 참조형을
            // 담을 수 있는 공간이 10개 생겼다.

            //new Item(); 만든 것.
            // 아래는 아이템을 만든 것이 아니다.
            // 아이템을 100개 담을 수 있는 공간을 만든 것이다. 
            // new Item[100];

            // Item NewItem -> 가리키는 역할
            Item NewItem = new Item();
            Item NewItem2 = NewItem; // NewItem2 또한 가리키는 역할 

            // 아이템이라는 메모리를
            // 가리킬 수 있는 참조형이 10개 생겼다.
            Item[] ArrItem = new Item[10];

            for (int i = 0; i < ArrInt.Length; i++)
            {
                ArrItem[i] = new Item(); 
            }

            // 
            ArrItem[0].Name = "철검";
            ArrItem[1].Name = "전설의검";
            ArrItem[2].Name = "갑옷";
            ArrItem[3].Name = "멋진 갑옷";
            ArrItem[4].Name = "포션";

            for (int i = 0; i < ArrInt.Length; i++)
            {
                Console.WriteLine(ArrItem[i].Name);
            }
            /*
             |||||***
             ********
             ********
            */

        }
    }
}
