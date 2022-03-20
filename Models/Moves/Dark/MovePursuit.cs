using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has double power against, and can hit, Pokémon attempting to switch out.
	public class MovePursuit : Move
	{
#nullable enable
		private static MovePursuit? _instance = null;
#nullable restore
        public static MovePursuit Instance => _instance ?? (_instance = new MovePursuit());

		public MovePursuit() : base(
			"Pursuit",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}