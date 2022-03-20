using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveFeintAttack : Move
	{
#nullable enable
		private static MoveFeintAttack? _instance = null;
#nullable restore
        public static MoveFeintAttack Instance => _instance ?? (_instance = new MoveFeintAttack());

		public MoveFeintAttack() : base(
			"Feint-Attack",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 60,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}