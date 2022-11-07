namespace CoffeMachineLib
{
    public class CoffeMachine
    {
        public CoffeMachine(string modelName)
        {
            _modelName = modelName;
        }
        string _modelName;

        float _coffe;
        float _milk;
        float _water;
        float _suggar;

        float _maxCoffe = 700;
        float _maxMilk = 2500;
        float _maxWater = 10000;
        float _maxSuggar = 1500;

        uint _cash;

        public bool CreateCoffe(CoffeType type, uint price)
        {
            if (type.Coffe > _coffe || type.Milk > _milk || type.Water > _water || type.Suggar > _suggar)
            {
                Console.WriteLine($"Not enough ingredients to make {type.TypeName}:");
                if (type.Coffe > _coffe)
                {
                    Console.WriteLine($"Coffe:  [{type.Coffe - _coffe}]");
                }
                if (type.Milk > _milk)
                {
                    Console.WriteLine($"Milk:   [{type.Milk - _milk}]");
                }
                if (type.Water > _water)
                {
                    Console.WriteLine($"Water:  [{type.Water - _water}]");
                }
                if (type.Suggar > _suggar)
                {
                    Console.WriteLine($"Suggar: [{type.Suggar - _suggar}]");
                }
                return false;
            }
            else
            {
                _coffe -= type.Coffe;
                _milk -= type.Milk;
                _water -= type.Water;
                _suggar -= type.Suggar;
                _cash += price;
                Console.WriteLine($"Your {type.TypeName} ready.");
                return true;
            }
        }
        public void CreateCoffe(CoffeType[] type, uint[] price)
        {
            for (int i = 0; i < type.Length; i++)
            {
                CreateCoffe(type[i], price[i]);
            }
        }
        public uint GetCash()
        {
            return _cash;
        }

        public void AddCoffe(float coffe)
        {
            if (this._coffe + coffe <= _maxCoffe)
                _coffe += coffe;
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
        public void AddSuggar(float suggar)
        {
            if (this._suggar + suggar <= _maxSuggar)
                _suggar += suggar;
        }
        public override string ToString()
        {
            return $"Coffe machine: {_modelName} \n" +
                $"Coffe: [{_coffe}/{_maxCoffe}] \n" +
                $"Milk:  [{_milk}/{_maxMilk}] \n" +
                $"Water  [{_water}/{_maxWater}] \n" +
                $"Suggar [{_suggar}/{_maxSuggar}]";
        }
    }
}