using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveMagnetBomb : Move
	{
		public MoveMagnetBomb() : base(
			"Magnet-Bomb",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 60,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}