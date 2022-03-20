using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePlasmaFists : Move
	{
#nullable enable
		private static MovePlasmaFists? _instance = null;
#nullable restore
        public static MovePlasmaFists Instance => _instance ?? (_instance = new MovePlasmaFists());

		public MovePlasmaFists() : base(
			"Plasma-Fists",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}