using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Ignores and destroys protection effects.
	public class MoveHyperspaceHole : Move
	{
#nullable enable
		private static MoveHyperspaceHole? _instance = null;
#nullable restore
        public static MoveHyperspaceHole Instance => _instance ?? (_instance = new MoveHyperspaceHole());

		public MoveHyperspaceHole() : base(
			"Hyperspace-Hole",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 80,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}