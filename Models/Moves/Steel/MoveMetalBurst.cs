using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Strikes back at the last Pokémon to hit the user this turn with 1.5× the damage.
	public class MoveMetalBurst : Move
	{
		public MoveMetalBurst() : base(
			"Metal-Burst",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}