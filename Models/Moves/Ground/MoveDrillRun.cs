using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveDrillRun : Move
	{
#nullable enable
		private static MoveDrillRun? _instance = null;
#nullable restore
        public static MoveDrillRun Instance => _instance ?? (_instance = new MoveDrillRun());

		public MoveDrillRun() : base(
			"Drill-Run",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 80,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}