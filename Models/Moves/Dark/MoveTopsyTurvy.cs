using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inverts the target's stat modifiers.
	public class MoveTopsyTurvy : Move
	{
#nullable enable
		private static MoveTopsyTurvy? _instance = null;
#nullable restore
        public static MoveTopsyTurvy Instance => _instance ?? (_instance = new MoveTopsyTurvy());

		public MoveTopsyTurvy() : base(
			"Topsy-Turvy",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}