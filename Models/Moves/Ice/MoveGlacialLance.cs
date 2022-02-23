using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveGlacialLance : Move
	{
		public MoveGlacialLance() : base(
			"Glacial-Lance",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 130,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}