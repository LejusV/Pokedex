using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePound : Move
	{
		public MovePound() : base(
			"Pound",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			35, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}