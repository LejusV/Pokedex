using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MovePinMissile : Move
	{
#nullable enable
		private static MovePinMissile? _instance = null;
#nullable restore
        public static MovePinMissile Instance => _instance ?? (_instance = new MovePinMissile());

		public MovePinMissile() : base(
			"Pin-Missile",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 25,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}