using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MovePulverizingPancake : Move
	{
#nullable enable
		private static MovePulverizingPancake? _instance = null;
#nullable restore
        public static MovePulverizingPancake Instance => _instance ?? (_instance = new MovePulverizingPancake());

		public MovePulverizingPancake() : base(
			"Pulverizing-Pancake",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, 210,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}