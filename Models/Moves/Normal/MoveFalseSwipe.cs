using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Cannot lower the target's HP below 1.
	public class MoveFalseSwipe : Move
	{
#nullable enable
		private static MoveFalseSwipe? _instance = null;
#nullable restore
        public static MoveFalseSwipe Instance => _instance ?? (_instance = new MoveFalseSwipe());

		public MoveFalseSwipe() : base(
			"False-Swipe",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			40, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}