using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to poison the target.
	public class MoveSludge : Move
	{
#nullable enable
		private static MoveSludge? _instance = null;
#nullable restore
        public static MoveSludge Instance => _instance ?? (_instance = new MoveSludge());

		public MoveSludge() : base(
			"Sludge",
			Poison.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 65,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}