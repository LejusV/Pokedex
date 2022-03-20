using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Seeds the target, stealing HP from it every turn.
	public class MoveLeechSeed : Move
	{
#nullable enable
		private static MoveLeechSeed? _instance = null;
#nullable restore
        public static MoveLeechSeed Instance => _instance ?? (_instance = new MoveLeechSeed());

		public MoveLeechSeed() : base(
			"Leech-Seed",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}