using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Covers the opposing field, lowering opponents' Speed by one stage upon switching in.
	public class MoveStickyWeb : Move
	{
#nullable enable
		private static MoveStickyWeb? _instance = null;
#nullable restore
        public static MoveStickyWeb Instance => _instance ?? (_instance = new MoveStickyWeb());

		public MoveStickyWeb() : base(
			"Sticky-Web",
			Bug.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}