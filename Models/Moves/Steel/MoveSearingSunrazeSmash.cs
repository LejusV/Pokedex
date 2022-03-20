using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Cannot be disrupted by abilities.
	public class MoveSearingSunrazeSmash : Move
	{
#nullable enable
		private static MoveSearingSunrazeSmash? _instance = null;
#nullable restore
        public static MoveSearingSunrazeSmash Instance => _instance ?? (_instance = new MoveSearingSunrazeSmash());

		public MoveSearingSunrazeSmash() : base(
			"Searing-Sunraze-Smash",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, 200,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}