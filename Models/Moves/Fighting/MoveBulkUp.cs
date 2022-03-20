using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Attack and Defense by one stage.
	public class MoveBulkUp : Move
	{
#nullable enable
		private static MoveBulkUp? _instance = null;
#nullable restore
        public static MoveBulkUp Instance => _instance ?? (_instance = new MoveBulkUp());

		public MoveBulkUp() : base(
			"Bulk-Up",
			Fighting.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}