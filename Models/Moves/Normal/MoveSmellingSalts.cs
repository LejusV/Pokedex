using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//If the target is paralyzed, inflicts double damage and cures the paralysis.
	public class MoveSmellingSalts : Move
	{
#nullable enable
		private static MoveSmellingSalts? _instance = null;
#nullable restore
        public static MoveSmellingSalts Instance => _instance ?? (_instance = new MoveSmellingSalts());

		public MoveSmellingSalts() : base(
			"Smelling-Salts",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}