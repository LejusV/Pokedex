using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the target from fleeing and inflicts damage for 2-5 turns.
	public class MoveSnapTrap : Move
	{
#nullable enable
		private static MoveSnapTrap? _instance = null;
#nullable restore
        public static MoveSnapTrap Instance => _instance ?? (_instance = new MoveSnapTrap());

		public MoveSnapTrap() : base(
			"Snap-Trap",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 35,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}