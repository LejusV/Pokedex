using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Adds ghost to the target's types.
	public class MoveTrickOrTreat : Move
	{
#nullable enable
		private static MoveTrickOrTreat? _instance = null;
#nullable restore
        public static MoveTrickOrTreat Instance => _instance ?? (_instance = new MoveTrickOrTreat());

		public MoveTrickOrTreat() : base(
			"Trick-Or-Treat",
			Ghost.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}