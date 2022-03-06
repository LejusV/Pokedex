using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Frees the user from binding moves, removes Leech Seed, and blows away Spikes.
	public class MoveRapidSpin : Move
	{
		public MoveRapidSpin() : base(
			"Rapid-Spin",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			40, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}