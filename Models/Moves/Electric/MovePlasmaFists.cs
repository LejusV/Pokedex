using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePlasmaFists : Move
	{
		public MovePlasmaFists() : base(
			"Plasma-Fists",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}