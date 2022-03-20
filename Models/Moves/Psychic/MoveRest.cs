using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User sleeps for two turns, completely healing itself.
	public class MoveRest : Move
	{
#nullable enable
		private static MoveRest? _instance = null;
#nullable restore
        public static MoveRest Instance => _instance ?? (_instance = new MoveRest());

		public MoveRest() : base(
			"Rest",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}