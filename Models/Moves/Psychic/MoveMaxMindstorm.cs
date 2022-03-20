using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxMindstorm : Move
	{
#nullable enable
		private static MoveMaxMindstorm? _instance = null;
#nullable restore
        public static MoveMaxMindstorm Instance => _instance ?? (_instance = new MoveMaxMindstorm());

		public MoveMaxMindstorm() : base(
			"Max-Mindstorm",
			Psychic.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}