using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Special Attack by two stages.
	public class MoveEerieImpulse : Move
	{
#nullable enable
		private static MoveEerieImpulse? _instance = null;
#nullable restore
        public static MoveEerieImpulse Instance => _instance ?? (_instance = new MoveEerieImpulse());

		public MoveEerieImpulse() : base(
			"Eerie-Impulse",
			Electric.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}