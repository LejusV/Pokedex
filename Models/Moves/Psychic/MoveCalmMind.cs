using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Special Attack and Special Defense by one stage.
	public class MoveCalmMind : Move
	{
#nullable enable
		private static MoveCalmMind? _instance = null;
#nullable restore
        public static MoveCalmMind Instance => _instance ?? (_instance = new MoveCalmMind());

		public MoveCalmMind() : base(
			"Calm-Mind",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}