using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveTailSlap : Move
	{
#nullable enable
		private static MoveTailSlap? _instance = null;
#nullable restore
        public static MoveTailSlap Instance => _instance ?? (_instance = new MoveTailSlap());

		public MoveTailSlap() : base(
			"Tail-Slap",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 25,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}