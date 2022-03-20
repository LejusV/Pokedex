using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts more damage when the user has less HP remaining, with a maximum of 200 power.
	public class MoveReversal : Move
	{
#nullable enable
		private static MoveReversal? _instance = null;
#nullable restore
        public static MoveReversal Instance => _instance ?? (_instance = new MoveReversal());

		public MoveReversal() : base(
			"Reversal",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}