using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSubzeroSlammerSpecial : Move
	{
#nullable enable
		private static MoveSubzeroSlammerSpecial? _instance = null;
#nullable restore
        public static MoveSubzeroSlammerSpecial Instance => _instance ?? (_instance = new MoveSubzeroSlammerSpecial());

		public MoveSubzeroSlammerSpecial() : base(
			"Subzero-Slammer--Special",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}