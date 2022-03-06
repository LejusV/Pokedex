using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveScaleShot : Move
	{
		public MoveScaleShot() : base(
			"Scale-Shot",
			Dragon.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 25,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}