namespace Pokedex.Models.Moves.Categories
{
    internal class Special : MoveCategory
    {
        private static Special? _instance = null;
        public static Special Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Special();
                }
                return _instance;
            }
        }
        private Special() : base(2, "Special", "Special moves deal damage depending on the Special Attack stat of the attacking Pokémon and the Special Defense stat of the defending Pokémon.")
        {
        }
    }
}
