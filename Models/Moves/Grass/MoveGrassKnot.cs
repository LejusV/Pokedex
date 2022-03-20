using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts more damage to heavier targets, with a maximum of 120 power.
	public class MoveGrassKnot : Move
	{
#nullable enable
		private static MoveGrassKnot? _instance = null;
#nullable restore
        public static MoveGrassKnot Instance => _instance ?? (_instance = new MoveGrassKnot());

		public MoveGrassKnot() : base(
			"Grass-Knot",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}