using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveLashOut : Move
	{
		public MoveLashOut() : base(
			"Lash-Out",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 75,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}