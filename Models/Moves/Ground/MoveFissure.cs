using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Causes a one-hit KO.
	public class MoveFissure : Move
	{
		public MoveFissure() : base(
			"Fissure",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, null,// PP & Pow
			30, 0 // Acc & Priority
			
		) {}
	}
}