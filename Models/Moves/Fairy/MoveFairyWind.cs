using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveFairyWind : Move
	{
#nullable enable
		private static MoveFairyWind? _instance = null;
#nullable restore
        public static MoveFairyWind Instance => _instance ?? (_instance = new MoveFairyWind());

		public MoveFairyWind() : base(
			"Fairy-Wind",
			Fairy.Instance, // Move Type
			MoveCategory.Special, // Move Category
			30, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}