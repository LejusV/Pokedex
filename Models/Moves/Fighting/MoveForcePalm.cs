using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to paralyze the target.
	public class MoveForcePalm : Move
	{
#nullable enable
		private static MoveForcePalm? _instance = null;
#nullable restore
        public static MoveForcePalm Instance => _instance ?? (_instance = new MoveForcePalm());

		public MoveForcePalm() : base(
			"Force-Palm",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}