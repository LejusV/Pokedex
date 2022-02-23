using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//With Fire Pledge, damages opposing Pokémon for 1/8 their max HP every turn for four turns.
	public class MoveGrassPledge : Move
	{
		public MoveGrassPledge() : base(
			"Grass-Pledge",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}