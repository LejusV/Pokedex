using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to raise all of the user's stats by one stage.
	public class MoveSilverWind : Move
	{
		public MoveSilverWind() : base(
			"Silver-Wind",
			Bug.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}