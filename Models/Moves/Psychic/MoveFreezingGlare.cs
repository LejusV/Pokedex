using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveFreezingGlare : Move
	{
#nullable enable
		private static MoveFreezingGlare? _instance = null;
#nullable restore
        public static MoveFreezingGlare Instance => _instance ?? (_instance = new MoveFreezingGlare());

		public MoveFreezingGlare() : base(
			"Freezing-Glare",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}