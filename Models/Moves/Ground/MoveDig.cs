using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User digs underground, dodging all attacks, and hits next turn.
	public class MoveDig : Move
	{
		public MoveDig() : base(
			"Dig",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}