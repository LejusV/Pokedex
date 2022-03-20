using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Steals the target's move, if it's self-targeted.
	public class MoveSnatch : Move
	{
#nullable enable
		private static MoveSnatch? _instance = null;
#nullable restore
        public static MoveSnatch Instance => _instance ?? (_instance = new MoveSnatch());

		public MoveSnatch() : base(
			"Snatch",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 4 // Acc & Priority
		) {}
	}
}