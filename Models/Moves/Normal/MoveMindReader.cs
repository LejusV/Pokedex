using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Ensures that the user's next move will hit the target.
	public class MoveMindReader : Move
	{
#nullable enable
		private static MoveMindReader? _instance = null;
#nullable restore
        public static MoveMindReader Instance => _instance ?? (_instance = new MoveMindReader());

		public MoveMindReader() : base(
			"Mind-Reader",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}