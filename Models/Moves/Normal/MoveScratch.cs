using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveScratch : Move
	{
		public MoveScratch() : base(
			"Scratch",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			35, 40,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}