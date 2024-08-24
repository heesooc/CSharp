class Player
{
    private int HP = 100;
    private int LV = 1;

    public int GetLv()
    {
        return LV;
    }

    public void SetHP(int _HP)
    {
    HP = _HP; 
    }

    public void Damage1(int _Dmg)
    {
        HP -= _Dmg;
    }
    public void Damage2(int _Dmg, int _SubDmg)
    {
        HP -= _Dmg + _SubDmg;
    }

    public int DamageToHPReturn(int _Dmg)
    {
        HP -= _Dmg;
        return HP;
    }
}

namespace _08FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            NewPlayer.SetHP(10000);
            NewPlayer.Damage1(10);
            NewPlayer.Damage2(10, 20);
            
            Console.WriteLine(NewPlayer.GetLv());
            Console.WriteLine(NewPlayer.DamageToHPReturn(50));
        }
    }
}
