using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts damage using either Attack or Special Attack stat, whichever is higher.
	public class MoveLightThatBurnsTheSky : Move
	{
		public MoveLightThatBurnsTheSky() : base(
			"Light-That-Burns-The-Sky",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, 200,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}