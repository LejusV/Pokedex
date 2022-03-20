using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User foregoes its next turn to recharge.
	public class MoveBlastBurn : Move
	{
#nullable enable
		private static MoveBlastBurn? _instance = null;
#nullable restore
        public static MoveBlastBurn Instance => _instance ?? (_instance = new MoveBlastBurn());

		public MoveBlastBurn() : base(
			"Blast-Burn",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 150,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}