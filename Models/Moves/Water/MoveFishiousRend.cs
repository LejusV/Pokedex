using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveFishiousRend : Move
	{
		public MoveFishiousRend() : base(
			"Fishious-Rend",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 85,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}