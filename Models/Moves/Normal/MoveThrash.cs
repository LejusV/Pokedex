using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits every turn for 2-3 turns, then confuses the user.
	public class MoveThrash : Move
	{
#nullable enable
		private static MoveThrash? _instance = null;
#nullable restore
        public static MoveThrash Instance => _instance ?? (_instance = new MoveThrash());

		public MoveThrash() : base(
			"Thrash",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}