namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine KJ36 = new CoffeeMachine("KJ36");
            //CoffeeMachine Cl4pTr4p2 = new CoffeeMachine(""); // Спроба створення класу с пустим ім'ям приведе до виключення
            KJ36.CreateCoffee(new CoffeeType("Esspreso", 20, 50, 150, 20), 150); // Вивід повідомлення про недостачу інгредієнтів
            Console.WriteLine(KJ36);
            KJ36.AddCoffee(400); //Додавання інгредієнтів
            KJ36.AddMilk(1200);
            KJ36.AddWater(6000);
            KJ36.AddSugar(1400);
            Console.WriteLine(KJ36);
            KJ36.CreateCoffee(new CoffeeType("Esspreso", 20, 50, 150, 20), 150); // Створення напою
            Console.WriteLine(KJ36);
            CoffeeType[] types =
            {
                new CoffeeType("Americano", 40, 0, 200, 40),
                new CoffeeType("Esspreso", 20, 50, 150, 60),
                new CoffeeType("Irish", 60, 75, 200, 70),
                new CoffeeType("Glace", 45, 50, 175, 50),
                new CoffeeType("RAF", 40, 100, 200, 70),
            };
            uint[] prices =
            {
                150,
                200,
                250,
                125,
                210
            };
            KJ36.CreateCoffee(types, prices); // Створення массиву напоїв
            Console.WriteLine(KJ36);
            Console.WriteLine($"Cash: [{KJ36.GetCash()}]"); // Вміст касси
            Console.ReadLine();
        }
    }
}