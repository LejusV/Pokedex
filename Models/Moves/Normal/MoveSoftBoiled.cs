using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Heals the user by half its max HP.
	public class MoveSoftBoiled : Move
	{
		public MoveSoftBoiled() : base(
			"Soft-Boiled",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}