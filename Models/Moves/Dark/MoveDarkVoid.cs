using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Puts the target to sleep.
	public class MoveDarkVoid : Move
	{
#nullable enable
		private static MoveDarkVoid? _instance = null;
#nullable restore
        public static MoveDarkVoid Instance => _instance ?? (_instance = new MoveDarkVoid());

		public MoveDarkVoid() : base(
			"Dark-Void",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			50, 0 // Acc & Priority
		) {}
	}
}