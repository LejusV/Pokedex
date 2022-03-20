using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User foregoes its next turn to recharge.
	public class MoveRoarOfTime : Move
	{
#nullable enable
		private static MoveRoarOfTime? _instance = null;
#nullable restore
        public static MoveRoarOfTime Instance => _instance ?? (_instance = new MoveRoarOfTime());

		public MoveRoarOfTime() : base(
			"Roar-Of-Time",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 150,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}