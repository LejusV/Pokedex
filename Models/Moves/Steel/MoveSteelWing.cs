using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to raise the user's Defense by one stage.
	public class MoveSteelWing : Move
	{
#nullable enable
		private static MoveSteelWing? _instance = null;
#nullable restore
        public static MoveSteelWing Instance => _instance ?? (_instance = new MoveSteelWing());

		public MoveSteelWing() : base(
			"Steel-Wing",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			25, 70,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}