using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveAuraSphere : Move
	{
		public MoveAuraSphere() : base(
			"Aura-Sphere",
			Fighting.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 80,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}