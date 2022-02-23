using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMegaPunch : Move
	{
		public MoveMegaPunch() : base(
			"Mega-Punch",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 80,// PP & Pow
			85, 0 // Acc & Priority
			
		) {}
	}
}