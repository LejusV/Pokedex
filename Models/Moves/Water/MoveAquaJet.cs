using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveAquaJet : Move
	{
		public MoveAquaJet() : base(
			"Aqua-Jet",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 40,// PP & Pow
			100, 1 // Acc & Priority
		) {}
	}
}