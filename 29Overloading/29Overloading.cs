class Player
{
    public enum DMGTYPE
    {
        PYDMG,
        FIREDMG,
        ICEDMG
    }

    // 물리방어
    int AttDef = 5;
    // 불방어
    int FireDef = 5;
    // 물방어
    int IceDef = 5;

    int Hp = 100;

    // 맴버함수, static함수, 생성자 오버로딩 다 가능
    public Player()
    {

    }

    public Player(int _Hp)
    {
        Hp = _Hp;
    }

    static void Func(int _Value)
    {

    }

    static void Func(int _Value, int _Value2)
    {

    }

    // Damageint
    // 함수오버로딩
    public void Damage(int _Damage)
    {
        Hp -= _Damage;
    }

    // Damagefloatint
    public void Damage(float _Damage, int _Type)
    {

    }

    // Damageintint
    public void Damage(int _Damage, DMGTYPE _Type)
    {
        switch (_Type)
        {
            case DMGTYPE.PYDMG:
                _Damage -= AttDef;
                break;
            case DMGTYPE.FIREDMG:
                _Damage -= FireDef;
                break;
            case DMGTYPE.ICEDMG:
                _Damage -= IceDef;
                break;
            default:
                break;
        }

        Damage(_Damage);
    }
}

namespace _29Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player(1000);
            NewPlayer.Damage(100, Player.DMGTYPE.FIREDMG);
        }
    }
}
