using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Attack by one stage.
	public class MoveMeditate : Move
	{
#nullable enable
		private static MoveMeditate? _instance = null;
#nullable restore
        public static MoveMeditate Instance => _instance ?? (_instance = new MoveMeditate());

		public MoveMeditate() : base(
			"Meditate",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}