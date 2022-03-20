using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to burn, freeze, or paralyze the target.
	public class MoveTriAttack : Move
	{
#nullable enable
		private static MoveTriAttack? _instance = null;
#nullable restore
        public static MoveTriAttack Instance => _instance ?? (_instance = new MoveTriAttack());

		public MoveTriAttack() : base(
			"Tri-Attack",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}