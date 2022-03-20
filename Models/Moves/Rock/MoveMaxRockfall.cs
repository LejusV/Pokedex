using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxRockfall : Move
	{
#nullable enable
		private static MoveMaxRockfall? _instance = null;
#nullable restore
        public static MoveMaxRockfall Instance => _instance ?? (_instance = new MoveMaxRockfall());

		public MoveMaxRockfall() : base(
			"Max-Rockfall",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}