using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts damage and removes any terrain present on the battlefield.
	public class MoveSplinteredStormshards : Move
	{
		public MoveSplinteredStormshards() : base(
			"Splintered-Stormshards",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, 190,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}