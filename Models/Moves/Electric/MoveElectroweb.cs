using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Speed by one stage.
	public class MoveElectroweb : Move
	{
		public MoveElectroweb() : base(
			"Electroweb",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 55,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}