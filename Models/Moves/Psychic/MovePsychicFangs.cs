using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Destroys Reflect and Light Screen.
	public class MovePsychicFangs : Move
	{
		public MovePsychicFangs() : base(
			"Psychic-Fangs",
			Psychic.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 85,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}