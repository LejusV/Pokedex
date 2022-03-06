using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Halves all Electric-type damage.
	public class MoveMudSport : Move
	{
		public MoveMudSport() : base(
			"Mud-Sport",
			Ground.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}