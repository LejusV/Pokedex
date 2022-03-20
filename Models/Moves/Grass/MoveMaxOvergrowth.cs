using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxOvergrowth : Move
	{
#nullable enable
		private static MoveMaxOvergrowth? _instance = null;
#nullable restore
        public static MoveMaxOvergrowth Instance => _instance ?? (_instance = new MoveMaxOvergrowth());

		public MoveMaxOvergrowth() : base(
			"Max-Overgrowth",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}