namespace Pokedex.Models.Players
{
    internal class PlayerAI : Player
    {
#nullable enable
        private static PlayerAI? _instance = null;
#nullable restore
        public static PlayerAI Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PlayerAI();
                }
                return _instance;
            }
        }
        public PlayerAI()
        : base("", Enums.Gender.O)
        { }
    }
}