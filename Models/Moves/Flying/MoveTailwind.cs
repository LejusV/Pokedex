using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//For three turns, friendly Pokémon have doubled Speed.
	public class MoveTailwind : Move
	{
#nullable enable
		private static MoveTailwind? _instance = null;
#nullable restore
        public static MoveTailwind Instance => _instance ?? (_instance = new MoveTailwind());

		public MoveTailwind() : base(
			"Tailwind",
			Flying.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}