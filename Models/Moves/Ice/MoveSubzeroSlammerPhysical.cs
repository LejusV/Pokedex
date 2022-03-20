using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSubzeroSlammerPhysical : Move
	{
#nullable enable
		private static MoveSubzeroSlammerPhysical? _instance = null;
#nullable restore
        public static MoveSubzeroSlammerPhysical Instance => _instance ?? (_instance = new MoveSubzeroSlammerPhysical());

		public MoveSubzeroSlammerPhysical() : base(
			"Subzero-Slammer--Physical",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}