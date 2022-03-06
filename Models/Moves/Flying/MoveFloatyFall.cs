using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveFloatyFall : Move
	{
		public MoveFloatyFall() : base(
			"Floaty-Fall",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 90,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}