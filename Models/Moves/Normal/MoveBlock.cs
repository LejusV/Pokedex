using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the target from leaving battle.
	public class MoveBlock : Move
	{
#nullable enable
		private static MoveBlock? _instance = null;
#nullable restore
        public static MoveBlock Instance => _instance ?? (_instance = new MoveBlock());

		public MoveBlock() : base(
			"Block",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}