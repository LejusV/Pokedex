using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the target from fleeing and inflicts damage for 2-5 turns.
	public class MoveMagmaStorm : Move
	{
		public MoveMagmaStorm() : base(
			"Magma-Storm",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 100,// PP & Pow
			75, 0 // Acc & Priority
		) {}
	}
}