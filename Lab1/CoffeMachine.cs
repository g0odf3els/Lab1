namespace CoffeeMachineLib
{
    public class CoffeeMachine
    {
        public CoffeeMachine(string modelName)
        {
            if(modelName == "")
                throw new Exception("Empty model name");

            _modelName = modelName;
        }
        string _modelName;

        float _coffee;
        float _milk;
        float _water;
        float _sugar;

        float _maxCoffee = 700;
        float _maxMilk = 2500;
        float _maxWater = 10000;
        float _maxSugar = 1500;

        uint _cash;

        public void CreateCoffee(CoffeeType type, uint price)
        {
            if (type.Coffee > _coffee || type.Milk > _milk || type.Water > _water || type.Sugar > _sugar)
            {
                Console.WriteLine($"Not enough ingredients to make {type.TypeName}:");
                if (type.Coffee > _coffee)
                {
                    Console.WriteLine($"Coffee: [{type.Coffee - _coffee}]");
                }
                if (type.Milk > _milk)
                {
                    Console.WriteLine($"Milk:   [{type.Milk - _milk}]");
                }
                if (type.Water > _water)
                {
                    Console.WriteLine($"Water:  [{type.Water - _water}]");
                }
                if (type.Sugar > _sugar)
                {
                    Console.WriteLine($"Sugar:  [{type.Sugar - _sugar}]");
                }
                return;
            }
            else
            {
                _coffee -= type.Coffee;
                _milk -= type.Milk;
                _water -= type.Water;
                _sugar -= type.Sugar;
                _cash += price;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Your {type.TypeName} ready.");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
        }
        public void CreateCoffee(CoffeeType[] type, uint[] price)
        {
            for (int i = 0; i < type.Length; i++)
            {
                CreateCoffee(type[i], price[i]);
            }
        }
        public uint GetCash()
        {
            return _cash;
        }

        public void AddCoffee(float coffee)
        {
            if (this._coffee + coffee <= _maxCoffee)
                _coffee += coffee;
        }
        public void AddMilk(float milk)
        {
            if (this._milk + milk <= _maxMilk)
                _milk += milk;
        }
        public void AddWater(uint water)
        {
            if (this._water + water <= _maxWater)
                _water += water;
        }
        public void AddSugar(float sugar)
        {
            if (this._sugar + sugar <= _maxSugar)
                _sugar += sugar;
        }
        public override string ToString()
        {
            return $"Coffe machine: {_modelName}\n" +
                $"Coffee: [{_coffee}/{_maxCoffee}]\n" +
                $"Milk:   [{_milk}/{_maxMilk}]\n" +
                $"Water   [{_water}/{_maxWater}]\n" +
                $"Suggar  [{_sugar}/{_maxSugar}]";
        }
    }
}