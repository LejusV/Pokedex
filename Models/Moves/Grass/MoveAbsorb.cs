using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Drains half the damage inflicted to heal the user.
	public class MoveAbsorb : Move
	{
		public MoveAbsorb() : base(
			"Absorb",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			25, 20,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}