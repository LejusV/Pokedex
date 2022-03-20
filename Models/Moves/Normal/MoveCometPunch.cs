using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveCometPunch : Move
	{
#nullable enable
		private static MoveCometPunch? _instance = null;
#nullable restore
        public static MoveCometPunch Instance => _instance ?? (_instance = new MoveCometPunch());

		public MoveCometPunch() : base(
			"Comet-Punch",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 18,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}