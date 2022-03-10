using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to put the target to sleep.
	public class MoveRelicSong : Move
	{
		public MoveRelicSong() : base(
			"Relic-Song",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 75,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}