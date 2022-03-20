using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveFreezyFrost : Move
	{
#nullable enable
		private static MoveFreezyFrost? _instance = null;
#nullable restore
        public static MoveFreezyFrost Instance => _instance ?? (_instance = new MoveFreezyFrost());

		public MoveFreezyFrost() : base(
			"Freezy-Frost",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 100,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}