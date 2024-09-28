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

        if (null != ArrItem[_Order])
        {
            return;
        }
        
        ArrItem[_Order] = _Item;
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
            } else 
            {
                Console.Write("■");
            }
        }

        Console.WriteLine("");
        Console.WriteLine("현재 선택한 아이템");
        Console.WriteLine("이름 : " + ArrItem[SelectIndex].Name);
        Console.WriteLine("가격 : " + ArrItem[SelectIndex].Gold);

    }
}

