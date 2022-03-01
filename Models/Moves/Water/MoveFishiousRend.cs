using Pokedex.Enums;
using Pokedex.Models.Types;

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
			1.0, 0 // Acc & Priority
		) {}
	}
}