using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Defense by two stages.
	public class MoveScreech : Move
	{
#nullable enable
		private static MoveScreech? _instance = null;
#nullable restore
        public static MoveScreech Instance => _instance ?? (_instance = new MoveScreech());

		public MoveScreech() : base(
			"Screech",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}