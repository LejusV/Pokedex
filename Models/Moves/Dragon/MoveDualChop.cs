using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits twice in one turn.
	public class MoveDualChop : Move
	{
#nullable enable
		private static MoveDualChop? _instance = null;
#nullable restore
        public static MoveDualChop Instance => _instance ?? (_instance = new MoveDualChop());

		public MoveDualChop() : base(
			"Dual-Chop",
			Dragon.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 40,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}