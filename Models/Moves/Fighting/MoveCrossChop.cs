using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveCrossChop : Move
	{
#nullable enable
		private static MoveCrossChop? _instance = null;
#nullable restore
        public static MoveCrossChop Instance => _instance ?? (_instance = new MoveCrossChop());

		public MoveCrossChop() : base(
			"Cross-Chop",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			80, 0 // Acc & Priority
		) {}
	}
}