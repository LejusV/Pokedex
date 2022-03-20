using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Ignores and destroys protection effects.
	public class MoveHyperspaceFury : Move
	{
#nullable enable
		private static MoveHyperspaceFury? _instance = null;
#nullable restore
        public static MoveHyperspaceFury Instance => _instance ?? (_instance = new MoveHyperspaceFury());

		public MoveHyperspaceFury() : base(
			"Hyperspace-Fury",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}