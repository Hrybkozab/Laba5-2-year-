namespace Laba5___2_year__;

class Program
{
    static void Main()
    {
        HotBeverage americano = new Americano(400);
        HotBeverage cappuccino = new Cappuccino(150);
        HotBeverage latte = new Latte(450);
        HotBeverage puer = new Puer(50);
        HotBeverage milkOolong = new MilkOolong(200);
        HotBeverage blackTea = new BlackTea(100);

        americano.Info();
        cappuccino.Info();
        latte.Info();
        puer.Info();
        milkOolong.Info();
        blackTea.Info();

        Console.ReadKey();
    }
}