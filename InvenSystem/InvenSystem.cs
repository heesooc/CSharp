

class InvenSystem
{
    static void Main(string[] args)
    {
        /*
         *****
         *****
         *****
         */
        // ctrl + R + R : 이름 바꾸는 단축키
        Inven NewInven = new Inven(5, 3);
        Item NewItem = new Item("철검", 100);
        // 뭐가 있어야겠다. 
        // 클래스
        // 속성들이 있다.
        // 아이템 배열을 맴버변수로 가졌다.
        // 넣는다. 동사.
        // 인벤에 아이템을 넣는다.
        // c#이라는 언어에 대해서 모른다.
        // 어느정도 배운 다음 절대로 안될거라고 생각하는
        // 녀석이 존재한다면
        // NewInven.ItemIn(NewItem);
        NewInven.ItemIn(new Item("철검", 100));
        NewInven.ItemIn(new Item("갑옷", 100));

        // 알아서 처리해줄거라는 생각 자체를 하지 말라.
        NewInven.ItemIn(new Item("포션", 100), 4);

        while (true)  
        {
            Console.Clear();
            NewInven.Render();
            Console.ReadKey();
        }
    }
}

