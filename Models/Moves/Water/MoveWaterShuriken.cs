using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits 2–5 times.
	public class MoveWaterShuriken : Move
	{
#nullable enable
		private static MoveWaterShuriken? _instance = null;
#nullable restore
        public static MoveWaterShuriken Instance => _instance ?? (_instance = new MoveWaterShuriken());

		public MoveWaterShuriken() : base(
			"Water-Shuriken",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 15,// PP & Pow
			100, 1 // Acc & Priority
		) {}
	}
}