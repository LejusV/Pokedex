using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveAerialAce : Move
	{
#nullable enable
		private static MoveAerialAce? _instance = null;
#nullable restore
        public static MoveAerialAce Instance => _instance ?? (_instance = new MoveAerialAce());

		public MoveAerialAce() : base(
			"Aerial-Ace",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 60,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}