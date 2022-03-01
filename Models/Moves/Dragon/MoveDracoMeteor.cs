using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the user's Special Attack by two stages after inflicting damage.
	public class MoveDracoMeteor : Move
	{
		public MoveDracoMeteor() : base(
			"Draco-Meteor",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 130,// PP & Pow
			0.9, 0 // Acc & Priority
		) {}
	}
}