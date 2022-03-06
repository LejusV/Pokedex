using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveOceanicOperetta : Move
	{
		public MoveOceanicOperetta() : base(
			"Oceanic-Operetta",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, 195,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}