using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User waits for two turns, then hits back for twice the damage it took.
	public class MoveBide : Move
	{
#nullable enable
		private static MoveBide? _instance = null;
#nullable restore
        public static MoveBide Instance => _instance ?? (_instance = new MoveBide());

		public MoveBide() : base(
			"Bide",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, null,// PP & Pow
			null, 1 // Acc & Priority
		) {}
	}
}