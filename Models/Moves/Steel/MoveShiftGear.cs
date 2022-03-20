using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Attack by one stage and its Speed by two stages.
	public class MoveShiftGear : Move
	{
#nullable enable
		private static MoveShiftGear? _instance = null;
#nullable restore
        public static MoveShiftGear Instance => _instance ?? (_instance = new MoveShiftGear());

		public MoveShiftGear() : base(
			"Shift-Gear",
			Steel.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}