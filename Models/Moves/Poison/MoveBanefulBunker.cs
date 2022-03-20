using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Grants the user protection for the rest of the turn and poisons any Pokémon that tries to use a contact move on it.
	public class MoveBanefulBunker : Move
	{
#nullable enable
		private static MoveBanefulBunker? _instance = null;
#nullable restore
        public static MoveBanefulBunker Instance => _instance ?? (_instance = new MoveBanefulBunker());

		public MoveBanefulBunker() : base(
			"Baneful-Bunker",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 4 // Acc & Priority
		) {}
	}
}