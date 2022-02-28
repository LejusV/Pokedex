using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveMagicalLeaf : Move
	{
		public MoveMagicalLeaf() : base(
			"Magical-Leaf",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 60,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}