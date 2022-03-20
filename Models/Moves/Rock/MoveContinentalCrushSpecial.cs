using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveContinentalCrushSpecial : Move
	{
#nullable enable
		private static MoveContinentalCrushSpecial? _instance = null;
#nullable restore
        public static MoveContinentalCrushSpecial Instance => _instance ?? (_instance = new MoveContinentalCrushSpecial());

		public MoveContinentalCrushSpecial() : base(
			"Continental-Crush--Special",
			Rock.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}