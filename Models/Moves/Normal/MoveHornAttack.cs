using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveHornAttack : Move
	{
#nullable enable
		private static MoveHornAttack? _instance = null;
#nullable restore
        public static MoveHornAttack Instance => _instance ?? (_instance = new MoveHornAttack());

		public MoveHornAttack() : base(
			"Horn-Attack",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			25, 65,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}