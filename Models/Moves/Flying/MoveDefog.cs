using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's evasion by one stage.  Removes field effects from the enemy field.
	public class MoveDefog : Move
	{
#nullable enable
		private static MoveDefog? _instance = null;
#nullable restore
        public static MoveDefog Instance => _instance ?? (_instance = new MoveDefog());

		public MoveDefog() : base(
			"Defog",
			Flying.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}