using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePoltergeist : Move
	{
		public MovePoltergeist() : base(
			"Poltergeist",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 110,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}