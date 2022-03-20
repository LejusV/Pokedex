using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveAttackOrder : Move
	{
#nullable enable
		private static MoveAttackOrder? _instance = null;
#nullable restore
        public static MoveAttackOrder Instance => _instance ?? (_instance = new MoveAttackOrder());

		public MoveAttackOrder() : base(
			"Attack-Order",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}