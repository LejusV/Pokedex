using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Traps the target.
	public class MoveAnchorShot : Move
	{
#nullable enable
		private static MoveAnchorShot? _instance = null;
#nullable restore
        public static MoveAnchorShot Instance => _instance ?? (_instance = new MoveAnchorShot());

		public MoveAnchorShot() : base(
			"Anchor-Shot",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}