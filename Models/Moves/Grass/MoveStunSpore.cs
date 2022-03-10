using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Paralyzes the target.
	public class MoveStunSpore : Move
	{
		public MoveStunSpore() : base(
			"Stun-Spore",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			75, 0 // Acc & Priority
		) {}
	}
}