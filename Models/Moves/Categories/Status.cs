namespace Pokedex.Models.Moves.Categories
{
    internal class Status : MoveCategory
    {
        private static Status? _instance = null;
        public static Status Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Status();
                }
                return _instance;
            }
        }
        private Status() : base(3, "Status", "Status moves include moves that change the weather, inflict status conditions, or raise or lower the stats of a Pokémon, among other effects. ")
        {
        }
    }
}
