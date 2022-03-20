using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's evasion by one stage.
	public class MoveSweetScent : Move
	{
#nullable enable
		private static MoveSweetScent? _instance = null;
#nullable restore
        public static MoveSweetScent Instance => _instance ?? (_instance = new MoveSweetScent());

		public MoveSweetScent() : base(
			"Sweet-Scent",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}