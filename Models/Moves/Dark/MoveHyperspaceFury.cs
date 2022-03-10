using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Ignores and destroys protection effects.
	public class MoveHyperspaceFury : Move
	{
		public MoveHyperspaceFury() : base(
			"Hyperspace-Fury",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}