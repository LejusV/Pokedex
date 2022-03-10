using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePeck : Move
	{
		public MovePeck() : base(
			"Peck",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			35, 35,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}