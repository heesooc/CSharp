// 사용자 정의 자료형인데.
using System.ComponentModel;

interface QuestUnit
{
    // 맴버변수 X
    // int A = 0;

    // 함수의 형태만 물려 줄 수 있는 문법이다.
    void Talk(QuestUnit _OtherUnit);
    void Event(QuestUnit _OtherUnit);
}

interface QuestUnit2
{
    // 맴버변수 X
    // int A = 0;

    // 함수의 형태만 물려 줄 수 있는 문법이다.
    void Talk(QuestUnit _OtherUnit);
    void Event(QuestUnit _OtherUnit);
}

class SkillUnit
{
    int AT;
}

class FightUnit
{
    int AT;
    int DMG;

    public void Damage()
    {

    }
}

// 인터페이스는 함수구현을 강제할 수 있다. 
// 인터페이스는 상속이라고 안하는 사람도 있다.
// 포함의 개념이다라고 말하는 사람도 있는데. 
// 인터페이스를 상속받았다고 치면,
// 상속주고 또 상속줄 수 있다.

class Player : FightUnit, QuestUnit, QuestUnit2
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }
    public void Event(QuestUnit _OtherUnit)
    {

    }
}

class NPC : FightUnit, QuestUnit, QuestUnit2
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }
    public void Event(QuestUnit _OtherUnit)
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        NPC NewNPC = new NPC();

        // 인터페이스는 실체가 없음.
        // QuestUnit NewQuestUnit = new QuestUnit(); (X)
        QuestUnit NewQuestUnit = NewNPC;
        // NewQuestUnit.Damage(); (X)

        // 업캐스팅이 된다.
        NewPlayer.Talk(NewNPC);
        NewNPC.Talk(NewPlayer);
    }
}

