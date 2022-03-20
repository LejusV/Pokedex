using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's accuracy by one stage.
	public class MoveSandAttack : Move
	{
#nullable enable
		private static MoveSandAttack? _instance = null;
#nullable restore
        public static MoveSandAttack Instance => _instance ?? (_instance = new MoveSandAttack());

		public MoveSandAttack() : base(
			"Sand-Attack",
			Ground.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}