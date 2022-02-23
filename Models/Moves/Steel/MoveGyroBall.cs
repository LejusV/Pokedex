using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Power raises when the user has lower Speed, up to a maximum of 150.
	public class MoveGyroBall : Move
	{
		public MoveGyroBall() : base(
			"Gyro-Ball",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, null,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}