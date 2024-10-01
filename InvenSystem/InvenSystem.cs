// 내가 만들었건 만들지 않았건 인터페이스란 내가 가용할 수 있는 코드를
// 내가 쓸 때 인터페이스(C#의 인터페이스를 의미하는게 아니다.)라고 한다.
// 어떻게 설계해야 하느냐는 각자의 선택에 따라 다르다.

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
        NewInven.ItemIn(new Item("포션", 100), -100);

        while (true)
        {
            // 이런 객체간의 구조를 만들 때 약간 도움이 될만한 규칙들
            // SOLID
            // 1. 단일 책임의 원칙
            // 2. 개방 폐쇄의 원칙
            // 3. 리스코프 치환의 원칙
            // 4. 인터페이스 분리의 원칙 // 이걸 말하려는 것.
            // ex) 함수를 잘개쪼개서 만든 다음
            //      그 잘개조깬 함수들을 조합해서 새 기능을 만들어 내라.

            // 5. 의존성 역전의 원칙

            Console.Clear();
            NewInven.Render();
            //NewInven.RenderToSelect();
            ConsoleKeyInfo CheckKey = Console.ReadKey();

            switch (CheckKey.Key)
            {
                case ConsoleKey.LeftArrow:
                    NewInven.SelectMoveLeft();
                    break;
                case ConsoleKey.RightArrow:
                    NewInven.SelectMoveRight();
                    break;
                case ConsoleKey.UpArrow:
                    NewInven.SelectMoveUp();
                    break;
                case ConsoleKey.DownArrow:
                    NewInven.SelectMoveDown();  
                    break;
                default:
                    break;
            }
        }
    }
}

