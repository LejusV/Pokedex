using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the target from fleeing and inflicts damage for 2-5 turns.
	public class MoveBind : Move
	{
#nullable enable
		private static MoveBind? _instance = null;
#nullable restore
        public static MoveBind Instance => _instance ?? (_instance = new MoveBind());

		public MoveBind() : base(
			"Bind",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 15,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}