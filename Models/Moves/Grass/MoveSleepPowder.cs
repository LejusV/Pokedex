using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Puts the target to sleep.
	public class MoveSleepPowder : Move
	{
#nullable enable
		private static MoveSleepPowder? _instance = null;
#nullable restore
        public static MoveSleepPowder Instance => _instance ?? (_instance = new MoveSleepPowder());

		public MoveSleepPowder() : base(
			"Sleep-Powder",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			75, 0 // Acc & Priority
		) {}
	}
}