using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Discards the user's stat changes and copies the target's.
	public class MovePsychUp : Move
	{
#nullable enable
		private static MovePsychUp? _instance = null;
#nullable restore
        public static MovePsychUp Instance => _instance ?? (_instance = new MovePsychUp());

		public MovePsychUp() : base(
			"Psych-Up",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}