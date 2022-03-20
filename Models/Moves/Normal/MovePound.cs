using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePound : Move
	{
#nullable enable
		private static MovePound? _instance = null;
#nullable restore
        public static MovePound Instance => _instance ?? (_instance = new MovePound());

		public MovePound() : base(
			"Pound",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			35, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}