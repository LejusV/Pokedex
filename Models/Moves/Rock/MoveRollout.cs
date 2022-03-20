using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power doubles every turn this move is used in succession after the first, resetting after five turns.
	public class MoveRollout : Move
	{
#nullable enable
		private static MoveRollout? _instance = null;
#nullable restore
        public static MoveRollout Instance => _instance ?? (_instance = new MoveRollout());

		public MoveRollout() : base(
			"Rollout",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 30,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}