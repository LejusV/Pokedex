using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveDoubleSlap : Move
	{
#nullable enable
		private static MoveDoubleSlap? _instance = null;
#nullable restore
        public static MoveDoubleSlap Instance => _instance ?? (_instance = new MoveDoubleSlap());

		public MoveDoubleSlap() : base(
			"Double-Slap",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 15,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}