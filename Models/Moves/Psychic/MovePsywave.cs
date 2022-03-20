using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts damage between 50% and 150% of the user's level.
	public class MovePsywave : Move
	{
#nullable enable
		private static MovePsywave? _instance = null;
#nullable restore
        public static MovePsywave Instance => _instance ?? (_instance = new MovePsywave());

		public MovePsywave() : base(
			"Psywave",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}