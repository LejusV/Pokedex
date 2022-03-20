using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Carries the target high into the air, dodging all attacks against either, and drops it next turn.
	public class MoveSkyDrop : Move
	{
#nullable enable
		private static MoveSkyDrop? _instance = null;
#nullable restore
        public static MoveSkyDrop Instance => _instance ?? (_instance = new MoveSkyDrop());

		public MoveSkyDrop() : base(
			"Sky-Drop",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}