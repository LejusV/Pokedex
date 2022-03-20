using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User and target swap items.
	public class MoveTrick : Move
	{
#nullable enable
		private static MoveTrick? _instance = null;
#nullable restore
        public static MoveTrick Instance => _instance ?? (_instance = new MoveTrick());

		public MoveTrick() : base(
			"Trick",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}