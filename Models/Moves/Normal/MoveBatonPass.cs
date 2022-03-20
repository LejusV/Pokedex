using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Allows the trainer to switch out the user and pass effects along to its replacement.
	public class MoveBatonPass : Move
	{
#nullable enable
		private static MoveBatonPass? _instance = null;
#nullable restore
        public static MoveBatonPass Instance => _instance ?? (_instance = new MoveBatonPass());

		public MoveBatonPass() : base(
			"Baton-Pass",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}