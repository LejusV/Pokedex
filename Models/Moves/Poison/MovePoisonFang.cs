using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 50% chance to badly poison the target.
	public class MovePoisonFang : Move
	{
#nullable enable
		private static MovePoisonFang? _instance = null;
#nullable restore
        public static MovePoisonFang Instance => _instance ?? (_instance = new MovePoisonFang());

		public MovePoisonFang() : base(
			"Poison-Fang",
			Poison.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}