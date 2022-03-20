using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Transfers the user's major status effect to the target.
	public class MovePsychoShift : Move
	{
#nullable enable
		private static MovePsychoShift? _instance = null;
#nullable restore
        public static MovePsychoShift Instance => _instance ?? (_instance = new MovePsychoShift());

		public MovePsychoShift() : base(
			"Psycho-Shift",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}