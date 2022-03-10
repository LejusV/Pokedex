using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBaddyBad : Move
	{
		public MoveBaddyBad() : base(
			"Baddy-Bad",
			Dark.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 80,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}