using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power increases against targets with more HP remaining, up to a maximum of 121 power.
	public class MoveCrushGrip : Move
	{
#nullable enable
		private static MoveCrushGrip? _instance = null;
#nullable restore
        public static MoveCrushGrip Instance => _instance ?? (_instance = new MoveCrushGrip());

		public MoveCrushGrip() : base(
			"Crush-Grip",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}