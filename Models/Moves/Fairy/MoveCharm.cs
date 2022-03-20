using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Attack by two stages.
	public class MoveCharm : Move
	{
#nullable enable
		private static MoveCharm? _instance = null;
#nullable restore
        public static MoveCharm Instance => _instance ?? (_instance = new MoveCharm());

		public MoveCharm() : base(
			"Charm",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}