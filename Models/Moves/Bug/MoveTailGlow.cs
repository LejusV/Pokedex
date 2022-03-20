using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Special Attack by three stages.
	public class MoveTailGlow : Move
	{
#nullable enable
		private static MoveTailGlow? _instance = null;
#nullable restore
        public static MoveTailGlow Instance => _instance ?? (_instance = new MoveTailGlow());

		public MoveTailGlow() : base(
			"Tail-Glow",
			Bug.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}