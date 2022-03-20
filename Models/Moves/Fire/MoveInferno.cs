using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to burn the target.
	public class MoveInferno : Move
	{
#nullable enable
		private static MoveInferno? _instance = null;
#nullable restore
        public static MoveInferno Instance => _instance ?? (_instance = new MoveInferno());

		public MoveInferno() : base(
			"Inferno",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 100,// PP & Pow
			50, 0 // Acc & Priority
		) {}
	}
}