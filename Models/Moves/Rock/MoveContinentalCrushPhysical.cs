using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveContinentalCrushPhysical : Move
	{
#nullable enable
		private static MoveContinentalCrushPhysical? _instance = null;
#nullable restore
        public static MoveContinentalCrushPhysical Instance => _instance ?? (_instance = new MoveContinentalCrushPhysical());

		public MoveContinentalCrushPhysical() : base(
			"Continental-Crush--Physical",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}