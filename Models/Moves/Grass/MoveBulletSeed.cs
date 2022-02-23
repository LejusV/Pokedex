using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveBulletSeed : Move
	{
		public MoveBulletSeed() : base(
			"Bullet-Seed",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, 25,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}