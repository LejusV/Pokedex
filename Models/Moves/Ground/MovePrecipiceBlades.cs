using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePrecipiceBlades : Move
	{
#nullable enable
		private static MovePrecipiceBlades? _instance = null;
#nullable restore
        public static MovePrecipiceBlades Instance => _instance ?? (_instance = new MovePrecipiceBlades());

		public MovePrecipiceBlades() : base(
			"Precipice-Blades",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 120,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}