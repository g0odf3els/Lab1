namespace CoffeMachineLib
{
   public class CoffeType
    {

        public CoffeType(string name, float coffe, float milk, float water, float suggar)
        {
            _typeName = name;
            _coffe = coffe;
            _milk = milk;
            _water = water;
            _suggar = suggar;
        }

        string _typeName;
        float _coffe;
        float _milk;
        float _water;
        float _suggar;

        public string TypeName
        {
            get { return _typeName; }
        }
        public float Coffe
        {
            get { return _coffe; }
        }
        public float Milk
        {
            get { return _milk; }
        }
        public float Water
        {
            get { return _water; }
        }
        public float Suggar
        {
            get { return _suggar; }
        }
    }

}

