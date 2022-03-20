using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to freeze the target.
	public class MovePowderSnow : Move
	{
#nullable enable
		private static MovePowderSnow? _instance = null;
#nullable restore
        public static MovePowderSnow Instance => _instance ?? (_instance = new MovePowderSnow());

		public MovePowderSnow() : base(
			"Powder-Snow",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			25, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}