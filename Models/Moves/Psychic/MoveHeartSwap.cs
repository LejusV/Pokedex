using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User and target swap stat changes.
	public class MoveHeartSwap : Move
	{
#nullable enable
		private static MoveHeartSwap? _instance = null;
#nullable restore
        public static MoveHeartSwap Instance => _instance ?? (_instance = new MoveHeartSwap());

		public MoveHeartSwap() : base(
			"Heart-Swap",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}