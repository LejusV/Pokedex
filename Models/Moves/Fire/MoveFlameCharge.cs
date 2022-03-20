using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage.  Raises the user's Speed by one stage.
	public class MoveFlameCharge : Move
	{
#nullable enable
		private static MoveFlameCharge? _instance = null;
#nullable restore
        public static MoveFlameCharge Instance => _instance ?? (_instance = new MoveFlameCharge());

		public MoveFlameCharge() : base(
			"Flame-Charge",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}