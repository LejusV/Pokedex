using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.  Only works if the user is sleeping.
	public class MoveSnore : Move
	{
		public MoveSnore() : base(
			"Snore",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}