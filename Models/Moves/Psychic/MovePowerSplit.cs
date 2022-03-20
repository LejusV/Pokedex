using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Averages Attack and Special Attack with the target.
	public class MovePowerSplit : Move
	{
#nullable enable
		private static MovePowerSplit? _instance = null;
#nullable restore
        public static MovePowerSplit Instance => _instance ?? (_instance = new MovePowerSplit());

		public MovePowerSplit() : base(
			"Power-Split",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}