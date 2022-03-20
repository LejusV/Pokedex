using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Requires a turn to charge before attacking.  Has a 30% chance to burn the target.
	public class MoveIceBurn : Move
	{
#nullable enable
		private static MoveIceBurn? _instance = null;
#nullable restore
        public static MoveIceBurn Instance => _instance ?? (_instance = new MoveIceBurn());

		public MoveIceBurn() : base(
			"Ice-Burn",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 140,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}