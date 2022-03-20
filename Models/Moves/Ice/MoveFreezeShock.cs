using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Requires a turn to charge before attacking.  Has a 30% chance to paralyze the target.
	public class MoveFreezeShock : Move
	{
#nullable enable
		private static MoveFreezeShock? _instance = null;
#nullable restore
        public static MoveFreezeShock Instance => _instance ?? (_instance = new MoveFreezeShock());

		public MoveFreezeShock() : base(
			"Freeze-Shock",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 140,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}