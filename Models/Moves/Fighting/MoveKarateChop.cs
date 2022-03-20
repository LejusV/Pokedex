using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveKarateChop : Move
	{
#nullable enable
		private static MoveKarateChop? _instance = null;
#nullable restore
        public static MoveKarateChop Instance => _instance ?? (_instance = new MoveKarateChop());

		public MoveKarateChop() : base(
			"Karate-Chop",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			25, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}