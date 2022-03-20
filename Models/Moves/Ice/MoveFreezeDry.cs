using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Super-effective against water.
	public class MoveFreezeDry : Move
	{
#nullable enable
		private static MoveFreezeDry? _instance = null;
#nullable restore
        public static MoveFreezeDry Instance => _instance ?? (_instance = new MoveFreezeDry());

		public MoveFreezeDry() : base(
			"Freeze-Dry",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}