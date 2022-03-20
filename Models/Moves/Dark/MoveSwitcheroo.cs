using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User and target swap items.
	public class MoveSwitcheroo : Move
	{
#nullable enable
		private static MoveSwitcheroo? _instance = null;
#nullable restore
        public static MoveSwitcheroo Instance => _instance ?? (_instance = new MoveSwitcheroo());

		public MoveSwitcheroo() : base(
			"Switcheroo",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}