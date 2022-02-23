using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveCut : Move
	{
		public MoveCut() : base(
			"Cut",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, 50,// PP & Pow
			95, 0 // Acc & Priority
			
		) {}
	}
}