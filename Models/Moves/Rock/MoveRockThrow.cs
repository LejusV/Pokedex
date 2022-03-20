using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveRockThrow : Move
	{
#nullable enable
		private static MoveRockThrow? _instance = null;
#nullable restore
        public static MoveRockThrow Instance => _instance ?? (_instance = new MoveRockThrow());

		public MoveRockThrow() : base(
			"Rock-Throw",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 50,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}