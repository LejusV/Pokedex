using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Heals the user by half its max HP.  Affected by weather.
	public class MoveSynthesis : Move
	{
#nullable enable
		private static MoveSynthesis? _instance = null;
#nullable restore
        public static MoveSynthesis Instance => _instance ?? (_instance = new MoveSynthesis());

		public MoveSynthesis() : base(
			"Synthesis",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}