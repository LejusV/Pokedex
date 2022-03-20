using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts damage based on the target's Defense, not Special Defense.
	public class MovePsystrike : Move
	{
#nullable enable
		private static MovePsystrike? _instance = null;
#nullable restore
        public static MovePsystrike Instance => _instance ?? (_instance = new MovePsystrike());

		public MovePsystrike() : base(
			"Psystrike",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}