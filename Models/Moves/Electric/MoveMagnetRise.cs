using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User is immune to Ground moves and effects for five turns.
	public class MoveMagnetRise : Move
	{
		public MoveMagnetRise() : base(
			"Magnet-Rise",
			Electric.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}