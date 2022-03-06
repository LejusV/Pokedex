using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits 2-5 times in one turn.
	public class MoveFurySwipes : Move
	{
		public MoveFurySwipes() : base(
			"Fury-Swipes",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 18,// PP & Pow
			80, 0 // Acc & Priority
		) {}
	}
}