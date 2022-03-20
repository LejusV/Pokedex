using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveWingAttack : Move
	{
#nullable enable
		private static MoveWingAttack? _instance = null;
#nullable restore
        public static MoveWingAttack Instance => _instance ?? (_instance = new MoveWingAttack());

		public MoveWingAttack() : base(
			"Wing-Attack",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			35, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}