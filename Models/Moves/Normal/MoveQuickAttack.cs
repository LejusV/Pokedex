using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveQuickAttack : Move
	{
#nullable enable
		private static MoveQuickAttack? _instance = null;
#nullable restore
        public static MoveQuickAttack Instance => _instance ?? (_instance = new MoveQuickAttack());

		public MoveQuickAttack() : base(
			"Quick-Attack",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, 40,// PP & Pow
			100, 1 // Acc & Priority
		) {}
	}
}