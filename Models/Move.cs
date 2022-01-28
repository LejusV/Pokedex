namespace Pokedex.Models
{
    internal abstract class Move
    {
        private readonly string p_name;
        private readonly int p_pp;
        private readonly int p_power;
        private readonly float p_accuracy;

        public string Name
        {
            get { return p_name; }
        }
        public int Pp
        {
            get { return p_pp; }
        }
        public int Power
        {
            get { return p_power; }
        }
        public float Accuracy
        {
            get { return p_accuracy; }
        }

        public Move(string name, PokemonType type, MoveCategory category, int pp, int power, float accuracy)
        {
            p_accuracy = accuracy;
            p_name = name;
            p_power = power;
            p_pp = pp;
        }
    }
}
