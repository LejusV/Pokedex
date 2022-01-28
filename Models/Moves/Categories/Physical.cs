namespace Pokedex.Models.Moves.Categories
{
    internal class Physical : MoveCategory
    {
        private static Physical? _instance = null;
        public static Physical Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Physical();
                }
                return _instance;
            }
        }
        private Physical() : base(1, "Physical", "Physical moves deal damage depending on both the Attack stat of the attacking Pokémon and the Defense stat of the defending Pokémon.")
        {
        }
    }
}
