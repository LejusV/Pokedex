using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Hits any Pokémon that shares a type with the user.
	public class MoveSynchronoise : Move
	{
		public MoveSynchronoise() : base(
			"Synchronoise",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}