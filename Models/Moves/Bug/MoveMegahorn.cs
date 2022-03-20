using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMegahorn : Move
	{
#nullable enable
		private static MoveMegahorn? _instance = null;
#nullable restore
        public static MoveMegahorn Instance => _instance ?? (_instance = new MoveMegahorn());

		public MoveMegahorn() : base(
			"Megahorn",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 120,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}