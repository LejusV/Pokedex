using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 40% chance to lower the target's Special Defense by two stages.
	public class MoveSeedFlare : Move
	{
#nullable enable
		private static MoveSeedFlare? _instance = null;
#nullable restore
        public static MoveSeedFlare Instance => _instance ?? (_instance = new MoveSeedFlare());

		public MoveSeedFlare() : base(
			"Seed-Flare",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 120,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}