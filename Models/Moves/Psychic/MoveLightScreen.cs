using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Reduces damage from special attacks by 50% for five turns.
	public class MoveLightScreen : Move
	{
		public MoveLightScreen() : base(
			"Light-Screen",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}