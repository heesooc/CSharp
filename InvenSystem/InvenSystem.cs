

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

        while (true) 
        {
            Console.Clear();
            NewInven.Render();
            Console.ReadKey();
        }
    }
}

