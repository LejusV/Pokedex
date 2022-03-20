using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to paralyze the target.
	public class MoveBoltStrike : Move
	{
#nullable enable
		private static MoveBoltStrike? _instance = null;
#nullable restore
        public static MoveBoltStrike Instance => _instance ?? (_instance = new MoveBoltStrike());

		public MoveBoltStrike() : base(
			"Bolt-Strike",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 130,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}