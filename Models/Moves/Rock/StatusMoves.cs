using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    internal class RockPolish : Move
    {
        private static RockPolish? _instance = null;
        public static RockPolish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RockPolish();
                }
                return _instance;
            }
        }

        private RockPolish() : base("Rock Polish",
                                    Rock.Instance,
                                    MoveCategory.Status,
                                    20, null, 1)
        { }
    }


    internal class TarShot : Move
    {
        private static TarShot? _instance = null;
        public static TarShot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TarShot();
                }
                return _instance;
            }
        }
        private TarShot() : base("Tar Shot",
                                    Rock.Instance,
                                    MoveCategory.Status,
                                    15)
        { }
    }
}
