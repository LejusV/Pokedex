using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User faints, and its replacement is fully healed.
	public class MoveLunarDance : Move
	{
#nullable enable
		private static MoveLunarDance? _instance = null;
#nullable restore
        public static MoveLunarDance Instance => _instance ?? (_instance = new MoveLunarDance());

		public MoveLunarDance() : base(
			"Lunar-Dance",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}