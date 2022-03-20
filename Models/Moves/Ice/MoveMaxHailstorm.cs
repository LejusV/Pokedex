using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxHailstorm : Move
	{
#nullable enable
		private static MoveMaxHailstorm? _instance = null;
#nullable restore
        public static MoveMaxHailstorm Instance => _instance ?? (_instance = new MoveMaxHailstorm());

		public MoveMaxHailstorm() : base(
			"Max-Hailstorm",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}