using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage.
	public class MoveBoomburst : Move
	{
		public MoveBoomburst() : base(
			"Boomburst",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 140,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}