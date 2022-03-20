using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to lower the target's Speed by one stage.
	public class MoveDrumBeating : Move
	{
#nullable enable
		private static MoveDrumBeating? _instance = null;
#nullable restore
        public static MoveDrumBeating Instance => _instance ?? (_instance = new MoveDrumBeating());

		public MoveDrumBeating() : base(
			"Drum-Beating",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}