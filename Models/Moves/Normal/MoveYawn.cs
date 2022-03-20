using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Target sleeps at the end of the next turn.
	public class MoveYawn : Move
	{
#nullable enable
		private static MoveYawn? _instance = null;
#nullable restore
        public static MoveYawn Instance => _instance ?? (_instance = new MoveYawn());

		public MoveYawn() : base(
			"Yawn",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}