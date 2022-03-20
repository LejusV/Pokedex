using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Makes the target act next this turn.
	public class MoveAfterYou : Move
	{
#nullable enable
		private static MoveAfterYou? _instance = null;
#nullable restore
        public static MoveAfterYou Instance => _instance ?? (_instance = new MoveAfterYou());

		public MoveAfterYou() : base(
			"After-You",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}