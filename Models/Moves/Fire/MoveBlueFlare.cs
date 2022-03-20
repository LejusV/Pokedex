using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to burn the target.
	public class MoveBlueFlare : Move
	{
#nullable enable
		private static MoveBlueFlare? _instance = null;
#nullable restore
        public static MoveBlueFlare Instance => _instance ?? (_instance = new MoveBlueFlare());

		public MoveBlueFlare() : base(
			"Blue-Flare",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 130,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}