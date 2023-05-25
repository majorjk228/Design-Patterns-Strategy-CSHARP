using Design_Patterns_Strategy_CSHARP.Strategy;

namespace Design_Patterns_Strategy_CSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Hero hero = new Hero("Alex");

            hero.Attack();

            hero.SetWeapon(new WaterGun());

            hero.Attack();
        }
    }
}