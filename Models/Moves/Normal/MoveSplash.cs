using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Does nothing.
	public class MoveSplash : Move
	{
#nullable enable
		private static MoveSplash? _instance = null;
#nullable restore
        public static MoveSplash Instance => _instance ?? (_instance = new MoveSplash());

		public MoveSplash() : base(
			"Splash",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}