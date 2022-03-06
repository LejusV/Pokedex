using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to burn the target and a 10% chance to make the target flinch.
	public class MoveFireFang : Move
	{
		public MoveFireFang() : base(
			"Fire-Fang",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 65,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}