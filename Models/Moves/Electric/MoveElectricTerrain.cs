using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//For five turns, prevents all Pokémon on the ground from sleeping and strengthens their electric moves to 1.5× their power.
	public class MoveElectricTerrain : Move
	{
		public MoveElectricTerrain() : base(
			"Electric-Terrain",
			Electric.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}