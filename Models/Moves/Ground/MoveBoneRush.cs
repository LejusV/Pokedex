using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveBoneRush : Move
	{
		public MoveBoneRush() : base(
			"Bone-Rush",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 25,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}