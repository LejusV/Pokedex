using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveFalseSurrender : Move
	{
#nullable enable
		private static MoveFalseSurrender? _instance = null;
#nullable restore
        public static MoveFalseSurrender Instance => _instance ?? (_instance = new MoveFalseSurrender());

		public MoveFalseSurrender() : base(
			"False-Surrender",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 80,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}