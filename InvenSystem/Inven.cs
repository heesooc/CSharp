using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

// 나는 아이템을 담아두는 인벤토리를 만들고싶다.
// 나는 인벤토리를 만들어질 때.
// 인벤토리가 최대 몇 개를 담을 수 있는지부터
// 정하지 않으면 인벤토리를 new 함수도 없어야 한다고
// 생각한다.
// 이때 숫자가 두 개 필요한데.
// x와 y이다.
// 그럼 담을 수 있는 아이템의 총 개수는?
// x * y


class Inven
{
    // 만들어 
    int SelectIndex = 0;

    Item[] ArrItem;
    int ItemX;
    int ItemY;

    // 잘못쓰기도 힘들게 만들어라.
    // 인벤토리를 new 하려면
    // int X와 Y를 넣어주는 방법밖에 없게 만들었다.
    public Inven(int _X, int _Y)
    {
        // 초보프로그래머가 가장 주의해야할 것.
        // 방어코드는 선택이 아니다.
        // 방어코드란 무엇이냐?
        // switch문의 디폴트
        // 혹은 프로그램이 터지거나 오작동하지 않게
        // 들어오는 값들을 체크해서 문제가 없게 만드는 코드라고
        // 함수나 이런 곳에서 인자값을 받을 때
        // 이걸 검사하고 사용한다. 1. (무조건 이 선택을 해라.)
        // 이걸 사용한다. 2.
        if (1 > _X)
        {
            _X = 1;
        }

        if (1 > _Y)
        {
            _Y = 1;
        }

        ItemX = _X;
        ItemY = _Y;
        ArrItem = new Item[_X * _Y];

    }

    // 객체의 교류
    // 인벤은 아이템이 필요해요.
    public void ItemIn(Item _Item)
    {
        int index = 0;
        // 인덱스만 몇 번이 될지 잘 정하면 된다.

        for (int i = 0; i < ArrItem.Length; i++)
        {
            if (null == ArrItem[i])
            {
                index = i;
                break;
            }
        }

        ArrItem[index] = _Item;
    }

    //
    public void ItemIn(Item _Item, int _Order)
    {
        // System.IndexOutOfRangeException 방어코드 만들어보기.
        if (_Order >= ItemX * ItemY || _Order < 0)
        {
            Console.WriteLine("인벤토리를 벗어났습니다.");
            return;
        }
        if (null != ArrItem[_Order])
        {
            return;
        }

        ArrItem[_Order] = _Item;
    }

    // 셀렉트 인덱스가 화면 바깥으로 넘어갔는가?
    public bool OverCheck(int _SelectIndex)
    {
        if (_SelectIndex >= ArrItem.Length || _SelectIndex <= -1)
        {
            return true;
        }

        return false;
    }

    // 인자값으로 어느 방향으로 움직였는지 주는 것이 좋다.
    public void SelectMove()
    {

    }

    public void SelectMoveLeft()
    {
        int CheckIndex = SelectIndex;
        CheckIndex -= 1;

        if(true == OverCheck(CheckIndex))
        {
            return;
        }

        SelectIndex -= 1;
    }
    public void SelectMoveRight()
    {
        int CheckIndex = SelectIndex;
        CheckIndex += 1;

        if (true == OverCheck(CheckIndex))
        {
            return;
        }

        SelectIndex += 1;
    }
    public void SelectMoveUp()
    {
        // 얘가 왜 위로 한칸?
        int CheckIndex = SelectIndex;
        CheckIndex -= ItemX;

        if (true == OverCheck(CheckIndex))
        {
            return;
        }

        SelectIndex -= ItemX;
    }
    public void SelectMoveDown()
    {
        int CheckIndex = SelectIndex;
        CheckIndex += ItemX;

        // 방어 코드
        if (true == OverCheck(CheckIndex))
        {
            return;
        }

        SelectIndex += ItemX;
    }

    public void Render()
    {
        for (int i = 0; i < ArrItem.Length; i++)
        {
            // 0 1 2 3 4
            // 5

            // i % 5
            if (i != 0 && i % ItemX == 0)
            {
                Console.WriteLine("");
            }

            // 15개의 아이템을 가질 수 있는 인벤.
            // i번째에 아이템이 있니?

            if (SelectIndex == i)
            {
                Console.Write("▣");
            }
            else if (null == ArrItem[i])
            {
                Console.Write("□");
            }
            else
            {
                Console.Write("■");
            }
        }

        Console.WriteLine("");

        if (ArrItem[SelectIndex] != null)
        {
            Console.WriteLine("현재 선택한 아이템");
            Console.WriteLine("이름 : " + ArrItem[SelectIndex].Name);
            Console.WriteLine("가격 : " + ArrItem[SelectIndex].Gold);
        }
        else 
        {
            Console.WriteLine("현재 선택한 아이템이 없습니다.");
        }
    }

    // 키 입력은 외부에서 받게 하자. 예) 플레이어 - 상점
    /*public void RenderToSelect()
    {
        Console.Clear();
        Render();

        //if(Console.ReadKey().Key == ConsoleKey.D){ }
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.D:
                Console.Clear();
                SelectIndex++;
                if (SelectIndex == ArrItem.Length)
                {
                    SelectIndex = 0;
                }
                Render();
                break;

            case ConsoleKey.A:
                Console.Clear();
                SelectIndex--;
                if (SelectIndex == -1)
                {
                    SelectIndex = ArrItem.Length - 1;
                }
                Render();
                break;
        }

    }*/
}

