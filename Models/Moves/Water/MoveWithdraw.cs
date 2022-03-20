using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Defense by one stage.
	public class MoveWithdraw : Move
	{
#nullable enable
		private static MoveWithdraw? _instance = null;
#nullable restore
        public static MoveWithdraw Instance => _instance ?? (_instance = new MoveWithdraw());

		public MoveWithdraw() : base(
			"Withdraw",
			Water.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}