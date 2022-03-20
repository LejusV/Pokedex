using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to paralyze the target.
	public class MoveZapCannon : Move
	{
#nullable enable
		private static MoveZapCannon? _instance = null;
#nullable restore
        public static MoveZapCannon Instance => _instance ?? (_instance = new MoveZapCannon());

		public MoveZapCannon() : base(
			"Zap-Cannon",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 120,// PP & Pow
			50, 0 // Acc & Priority
		) {}
	}
}