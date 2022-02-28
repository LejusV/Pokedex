using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//For five turns, protects all Pokémon on the ground from major status ailments and confusion, and halves the power of incoming dragon moves.
	public class MoveMistyTerrain : Move
	{
		public MoveMistyTerrain() : base(
			"Misty-Terrain",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}