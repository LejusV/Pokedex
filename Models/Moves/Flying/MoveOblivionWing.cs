using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Drains 75% of the damage inflicted to heal the user.
	public class MoveOblivionWing : Move
	{
		public MoveOblivionWing() : base(
			"Oblivion-Wing",
			Flying.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}