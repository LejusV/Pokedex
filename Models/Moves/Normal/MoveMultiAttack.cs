using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//If the user is holding a appropriate plate or drive, the damage inflicted will match it.
	public class MoveMultiAttack : Move
	{
#nullable enable
		private static MoveMultiAttack? _instance = null;
#nullable restore
        public static MoveMultiAttack Instance => _instance ?? (_instance = new MoveMultiAttack());

		public MoveMultiAttack() : base(
			"Multi-Attack",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}