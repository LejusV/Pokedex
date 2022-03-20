using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to make the target flinch.
	public class MoveWaterfall : Move
	{
#nullable enable
		private static MoveWaterfall? _instance = null;
#nullable restore
        public static MoveWaterfall Instance => _instance ?? (_instance = new MoveWaterfall());

		public MoveWaterfall() : base(
			"Waterfall",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}