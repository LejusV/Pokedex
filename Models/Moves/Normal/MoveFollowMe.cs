using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Redirects the target's single-target effects to the user for this turn.
	public class MoveFollowMe : Move
	{
#nullable enable
		private static MoveFollowMe? _instance = null;
#nullable restore
        public static MoveFollowMe Instance => _instance ?? (_instance = new MoveFollowMe());

		public MoveFollowMe() : base(
			"Follow-Me",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 2 // Acc & Priority
		) {}
	}
}