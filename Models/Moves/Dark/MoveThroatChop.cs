using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the target from using sound-based moves for two turns.
	public class MoveThroatChop : Move
	{
#nullable enable
		private static MoveThroatChop? _instance = null;
#nullable restore
        public static MoveThroatChop Instance => _instance ?? (_instance = new MoveThroatChop());

		public MoveThroatChop() : base(
			"Throat-Chop",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}