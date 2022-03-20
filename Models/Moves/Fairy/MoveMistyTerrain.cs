using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//For five turns, protects all Pokémon on the ground from major status ailments and confusion, and halves the power of incoming dragon moves.
	public class MoveMistyTerrain : Move
	{
#nullable enable
		private static MoveMistyTerrain? _instance = null;
#nullable restore
        public static MoveMistyTerrain Instance => _instance ?? (_instance = new MoveMistyTerrain());

		public MoveMistyTerrain() : base(
			"Misty-Terrain",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}