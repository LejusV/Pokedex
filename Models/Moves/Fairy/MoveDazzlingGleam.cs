using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveDazzlingGleam : Move
	{
#nullable enable
		private static MoveDazzlingGleam? _instance = null;
#nullable restore
        public static MoveDazzlingGleam Instance => _instance ?? (_instance = new MoveDazzlingGleam());

		public MoveDazzlingGleam() : base(
			"Dazzling-Gleam",
			Fairy.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}