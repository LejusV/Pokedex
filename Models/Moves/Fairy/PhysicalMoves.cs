using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    #nullable enable
    /// <summary>
    /// 30% chances to put fear on target (can't attack this turn)
    /// </summary>
    internal class PlayRough : Move
    {
        private static PlayRough? _instance = null;
        public static PlayRough Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PlayRough();
                }
                return _instance;
            }
        }
        private PlayRough() : base("Play Rough", Fairy.Instance, MoveCategory.Physical, 10, 90, 0.9)
        { }
    }
}
