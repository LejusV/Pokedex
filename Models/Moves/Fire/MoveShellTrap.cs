using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Only inflicts damage if the user was hit by a physical move this turn.
	public class MoveShellTrap : Move
	{
#nullable enable
		private static MoveShellTrap? _instance = null;
#nullable restore
        public static MoveShellTrap Instance => _instance ?? (_instance = new MoveShellTrap());

		public MoveShellTrap() : base(
			"Shell-Trap",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 150,// PP & Pow
			100, -3 // Acc & Priority
		) {}
	}
}