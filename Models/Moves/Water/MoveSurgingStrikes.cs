using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSurgingStrikes : Move
	{
#nullable enable
		private static MoveSurgingStrikes? _instance = null;
#nullable restore
        public static MoveSurgingStrikes Instance => _instance ?? (_instance = new MoveSurgingStrikes());

		public MoveSurgingStrikes() : base(
			"Surging-Strikes",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 25,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}