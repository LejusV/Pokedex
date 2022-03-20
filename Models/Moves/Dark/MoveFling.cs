using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Throws held item at the target; power depends on the item.
	public class MoveFling : Move
	{
#nullable enable
		private static MoveFling? _instance = null;
#nullable restore
        public static MoveFling Instance => _instance ?? (_instance = new MoveFling());

		public MoveFling() : base(
			"Fling",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}