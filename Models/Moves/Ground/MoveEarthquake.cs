using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage and can hit Dig users.
	public class MoveEarthquake : Move
	{
		public MoveEarthquake() : base(
			"Earthquake",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}