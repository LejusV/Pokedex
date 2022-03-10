using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the user's Attack and Defense by one stage after inflicting damage.
	public class MoveSuperpower : Move
	{
		public MoveSuperpower() : base(
			"Superpower",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}