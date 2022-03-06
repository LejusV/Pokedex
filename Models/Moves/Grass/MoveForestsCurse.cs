using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Adds grass to the target's types.
	public class MoveForestsCurse : Move
	{
		public MoveForestsCurse() : base(
			"Forests-Curse",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}