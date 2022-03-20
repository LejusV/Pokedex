using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the target from using the same move twice in a row.
	public class MoveTorment : Move
	{
#nullable enable
		private static MoveTorment? _instance = null;
#nullable restore
        public static MoveTorment Instance => _instance ?? (_instance = new MoveTorment());

		public MoveTorment() : base(
			"Torment",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}