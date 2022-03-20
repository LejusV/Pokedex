using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MovePsychoCut : Move
	{
#nullable enable
		private static MovePsychoCut? _instance = null;
#nullable restore
        public static MovePsychoCut Instance => _instance ?? (_instance = new MovePsychoCut());

		public MovePsychoCut() : base(
			"Psycho-Cut",
			Psychic.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}