using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Changes the weather to a sandstorm for five turns.
	public class MoveSandstorm : Move
	{
#nullable enable
		private static MoveSandstorm? _instance = null;
#nullable restore
        public static MoveSandstorm Instance => _instance ?? (_instance = new MoveSandstorm());

		public MoveSandstorm() : base(
			"Sandstorm",
			Rock.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}