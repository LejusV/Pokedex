using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to paralyze the target.
	public class MoveThunderbolt : Move
	{
#nullable enable
		private static MoveThunderbolt? _instance = null;
#nullable restore
        public static MoveThunderbolt Instance => _instance ?? (_instance = new MoveThunderbolt());

		public MoveThunderbolt() : base(
			"Thunderbolt",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}