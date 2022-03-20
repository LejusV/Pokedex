using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Destroys Reflect and Light Screen.
	public class MovePsychicFangs : Move
	{
#nullable enable
		private static MovePsychicFangs? _instance = null;
#nullable restore
        public static MovePsychicFangs Instance => _instance ?? (_instance = new MovePsychicFangs());

		public MovePsychicFangs() : base(
			"Psychic-Fangs",
			Psychic.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 85,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}