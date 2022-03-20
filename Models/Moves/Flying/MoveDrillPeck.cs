using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveDrillPeck : Move
	{
#nullable enable
		private static MoveDrillPeck? _instance = null;
#nullable restore
        public static MoveDrillPeck Instance => _instance ?? (_instance = new MoveDrillPeck());

		public MoveDrillPeck() : base(
			"Drill-Peck",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}