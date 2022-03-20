using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Forces the target's opponents to aim at the target for the rest of the turn.
	public class MoveSpotlight : Move
	{
#nullable enable
		private static MoveSpotlight? _instance = null;
#nullable restore
        public static MoveSpotlight Instance => _instance ?? (_instance = new MoveSpotlight());

		public MoveSpotlight() : base(
			"Spotlight",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 3 // Acc & Priority
		) {}
	}
}