using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//For five turns, heals all Pokémon on the ground for 1/16 max HP each turn and strengthens their grass moves to 1.5× their power.
	public class MoveGrassyTerrain : Move
	{
		public MoveGrassyTerrain() : base(
			"Grassy-Terrain",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}