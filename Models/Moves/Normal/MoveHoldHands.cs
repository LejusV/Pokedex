using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Does nothing.
	public class MoveHoldHands : Move
	{
#nullable enable
		private static MoveHoldHands? _instance = null;
#nullable restore
        public static MoveHoldHands Instance => _instance ?? (_instance = new MoveHoldHands());

		public MoveHoldHands() : base(
			"Hold-Hands",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}