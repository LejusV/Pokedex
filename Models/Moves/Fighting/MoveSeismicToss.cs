using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts damage equal to the user's level.
	public class MoveSeismicToss : Move
	{
		public MoveSeismicToss() : base(
			"Seismic-Toss",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}