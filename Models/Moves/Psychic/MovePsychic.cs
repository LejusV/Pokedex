using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to lower the target's Special Defense by one stage.
	public class MovePsychic : Move
	{
#nullable enable
		private static MovePsychic? _instance = null;
#nullable restore
        public static MovePsychic Instance => _instance ?? (_instance = new MovePsychic());

		public MovePsychic() : base(
			"Psychic",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}