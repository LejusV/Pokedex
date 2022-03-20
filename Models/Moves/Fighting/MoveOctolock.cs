using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveOctolock : Move
	{
#nullable enable
		private static MoveOctolock? _instance = null;
#nullable restore
        public static MoveOctolock Instance => _instance ?? (_instance = new MoveOctolock());

		public MoveOctolock() : base(
			"Octolock",
			Fighting.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}