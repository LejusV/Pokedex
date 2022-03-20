using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxSteelspike : Move
	{
#nullable enable
		private static MoveMaxSteelspike? _instance = null;
#nullable restore
        public static MoveMaxSteelspike Instance => _instance ?? (_instance = new MoveMaxSteelspike());

		public MoveMaxSteelspike() : base(
			"Max-Steelspike",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}