using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Protects Pokémon on the ground from priority moves and increases the power of their  Psychic moves by 50%.
	public class MovePsychicTerrain : Move
	{
		public MovePsychicTerrain() : base(
			"Psychic-Terrain",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}