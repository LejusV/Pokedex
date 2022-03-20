using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBranchPoke : Move
	{
#nullable enable
		private static MoveBranchPoke? _instance = null;
#nullable restore
        public static MoveBranchPoke Instance => _instance ?? (_instance = new MoveBranchPoke());

		public MoveBranchPoke() : base(
			"Branch-Poke",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			40, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}