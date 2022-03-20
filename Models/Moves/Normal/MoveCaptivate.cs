using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Special Attack by two stages if it's the opposite gender.
	public class MoveCaptivate : Move
	{
#nullable enable
		private static MoveCaptivate? _instance = null;
#nullable restore
        public static MoveCaptivate Instance => _instance ?? (_instance = new MoveCaptivate());

		public MoveCaptivate() : base(
			"Captivate",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}