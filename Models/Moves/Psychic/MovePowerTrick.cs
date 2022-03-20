using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User swaps Attack and Defense.
	public class MovePowerTrick : Move
	{
#nullable enable
		private static MovePowerTrick? _instance = null;
#nullable restore
        public static MovePowerTrick Instance => _instance ?? (_instance = new MovePowerTrick());

		public MovePowerTrick() : base(
			"Power-Trick",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}