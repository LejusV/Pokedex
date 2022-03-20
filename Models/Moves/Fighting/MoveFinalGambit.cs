using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts damage equal to the user's remaining HP.  User faints.
	public class MoveFinalGambit : Move
	{
#nullable enable
		private static MoveFinalGambit? _instance = null;
#nullable restore
        public static MoveFinalGambit Instance => _instance ?? (_instance = new MoveFinalGambit());

		public MoveFinalGambit() : base(
			"Final-Gambit",
			Fighting.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}