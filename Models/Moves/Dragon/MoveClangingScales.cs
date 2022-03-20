using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the user's Defense by one stage after inflicting damage.
	public class MoveClangingScales : Move
	{
#nullable enable
		private static MoveClangingScales? _instance = null;
#nullable restore
        public static MoveClangingScales Instance => _instance ?? (_instance = new MoveClangingScales());

		public MoveClangingScales() : base(
			"Clanging-Scales",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 110,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}