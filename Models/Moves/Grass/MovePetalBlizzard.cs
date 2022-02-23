using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage.
	public class MovePetalBlizzard : Move
	{
		public MovePetalBlizzard() : base(
			"Petal-Blizzard",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 90,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}