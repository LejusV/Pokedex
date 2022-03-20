using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Moves have 100% accuracy against the target for three turns.
	public class MoveTelekinesis : Move
	{
#nullable enable
		private static MoveTelekinesis? _instance = null;
#nullable restore
        public static MoveTelekinesis Instance => _instance ?? (_instance = new MoveTelekinesis());

		public MoveTelekinesis() : base(
			"Telekinesis",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}