using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxQuake : Move
	{
#nullable enable
		private static MoveMaxQuake? _instance = null;
#nullable restore
        public static MoveMaxQuake Instance => _instance ?? (_instance = new MoveMaxQuake());

		public MoveMaxQuake() : base(
			"Max-Quake",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}