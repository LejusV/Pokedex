using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User swaps Defense and Special Defense changes with the target.
	public class MoveGuardSwap : Move
	{
#nullable enable
		private static MoveGuardSwap? _instance = null;
#nullable restore
        public static MoveGuardSwap Instance => _instance ?? (_instance = new MoveGuardSwap());

		public MoveGuardSwap() : base(
			"Guard-Swap",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}