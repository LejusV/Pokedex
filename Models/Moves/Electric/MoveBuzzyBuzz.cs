using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBuzzyBuzz : Move
	{
#nullable enable
		private static MoveBuzzyBuzz? _instance = null;
#nullable restore
        public static MoveBuzzyBuzz Instance => _instance ?? (_instance = new MoveBuzzyBuzz());

		public MoveBuzzyBuzz() : base(
			"Buzzy-Buzz",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}