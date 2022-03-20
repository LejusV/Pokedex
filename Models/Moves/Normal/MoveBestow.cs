using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Gives the user's held item to the target.
	public class MoveBestow : Move
	{
#nullable enable
		private static MoveBestow? _instance = null;
#nullable restore
        public static MoveBestow Instance => _instance ?? (_instance = new MoveBestow());

		public MoveBestow() : base(
			"Bestow",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}