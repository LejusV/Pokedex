using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Only works on sleeping Pokémon.  Drains half the damage inflicted to heal the user.
	public class MoveDreamEater : Move
	{
		public MoveDreamEater() : base(
			"Dream-Eater",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 100,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}