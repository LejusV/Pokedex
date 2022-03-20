using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits once for every conscious Pokémon the trainer has.
	public class MoveBeatUp : Move
	{
#nullable enable
		private static MoveBeatUp? _instance = null;
#nullable restore
        public static MoveBeatUp Instance => _instance ?? (_instance = new MoveBeatUp());

		public MoveBeatUp() : base(
			"Beat-Up",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}