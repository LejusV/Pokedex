using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveStoneEdge : Move
	{
#nullable enable
		private static MoveStoneEdge? _instance = null;
#nullable restore
        public static MoveStoneEdge Instance => _instance ?? (_instance = new MoveStoneEdge());

		public MoveStoneEdge() : base(
			"Stone-Edge",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			80, 0 // Acc & Priority
		) {}
	}
}