using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to lower the target's Special Defense by one stage.
	public class MoveFlashCannon : Move
	{
#nullable enable
		private static MoveFlashCannon? _instance = null;
#nullable restore
        public static MoveFlashCannon Instance => _instance ?? (_instance = new MoveFlashCannon());

		public MoveFlashCannon() : base(
			"Flash-Cannon",
			Steel.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}