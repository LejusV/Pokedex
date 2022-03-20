using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 50% chance to raise the user's Defense by two stages for each target hit.
	public class MoveDiamondStorm : Move
	{
#nullable enable
		private static MoveDiamondStorm? _instance = null;
#nullable restore
        public static MoveDiamondStorm Instance => _instance ?? (_instance = new MoveDiamondStorm());

		public MoveDiamondStorm() : base(
			"Diamond-Storm",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}