using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to raise all of the user's stats by one stage.
	public class MoveOminousWind : Move
	{
		public MoveOminousWind() : base(
			"Ominous-Wind",
			Ghost.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}