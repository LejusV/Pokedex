using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxStarfall : Move
	{
#nullable enable
		private static MoveMaxStarfall? _instance = null;
#nullable restore
        public static MoveMaxStarfall Instance => _instance ?? (_instance = new MoveMaxStarfall());

		public MoveMaxStarfall() : base(
			"Max-Starfall",
			Fairy.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}