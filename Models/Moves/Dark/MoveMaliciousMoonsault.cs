using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaliciousMoonsault : Move
	{
		public MoveMaliciousMoonsault() : base(
			"Malicious-Moonsault",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, 180,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}