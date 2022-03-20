using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to lower the target's Special Attack by one stage.
	public class MoveSnarl : Move
	{
#nullable enable
		private static MoveSnarl? _instance = null;
#nullable restore
        public static MoveSnarl Instance => _instance ?? (_instance = new MoveSnarl());

		public MoveSnarl() : base(
			"Snarl",
			Dark.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 55,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}