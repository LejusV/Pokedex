using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveEggBomb : Move
	{
		public MoveEggBomb() : base(
			"Egg-Bomb",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 100,// PP & Pow
			75, 0 // Acc & Priority
			
		) {}
	}
}