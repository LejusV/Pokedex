using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePrecipiceBlades : Move
	{
		public MovePrecipiceBlades() : base(
			"Precipice-Blades",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 120,// PP & Pow
			85, 0 // Acc & Priority
			
		) {}
	}
}