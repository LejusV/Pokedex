using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User foregoes its next turn to recharge.
	public class MoveHydroCannon : Move
	{
#nullable enable
		private static MoveHydroCannon? _instance = null;
#nullable restore
        public static MoveHydroCannon Instance => _instance ?? (_instance = new MoveHydroCannon());

		public MoveHydroCannon() : base(
			"Hydro-Cannon",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 150,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}