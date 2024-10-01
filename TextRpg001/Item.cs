using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 하루에 2시간씩 투자한다고 쳤을 때 8개월 정도 예상한다.
// 운동과 같아서 꾸준히 해야한다.
// 맵 캐릭터 인벤토리 씨앗 애완동물
// 다 만들 수 있는 실력을 가졌다 하더라도
// 자기가 무엇부터 만드는게 좋을까?
// 그 테크닉을 알려줄 수 있는 사람이 있다면 무조건 도움을 받으세요
// 캐릭터 -> FSM(유한 상태기계)(유한 상태기계에 대해서 오해하는게 인공지능에 쓴다.)
// 기능 하나하나는 어느 정도 수준까지(버그가 보이지 않는 수준까지 만들고)
// 왔다 갔다. -> 인벤토리 했다 캐릭터 했다 인벤토리 했다 캐릭터 했다.
// 자기가 이걸 만드는데 얼마나 걸릴까?

class Item
{
    string mName;
    int mGold;

    // 시작부터 쓸거라고 예상하고 만드는건
    // 별로 안좋은데
    public string Name
    {
        get { return mName; }
        set { mName = value; }
    }
    public int Gold
    {
        get { return mGold; }
        set { mGold = value; }
    }

    public Item(string _Name, int _Gold)
    {
        Name = _Name;
        Gold = _Gold;
    }
}

