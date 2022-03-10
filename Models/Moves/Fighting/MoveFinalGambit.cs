using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts damage equal to the user's remaining HP.  User faints.
	public class MoveFinalGambit : Move
	{
		public MoveFinalGambit() : base(
			"Final-Gambit",
			Fighting.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}