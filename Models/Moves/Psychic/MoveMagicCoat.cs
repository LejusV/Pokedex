using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Reflects back the first effect move used on the user this turn.
	public class MoveMagicCoat : Move
	{
#nullable enable
		private static MoveMagicCoat? _instance = null;
#nullable restore
        public static MoveMagicCoat Instance => _instance ?? (_instance = new MoveMagicCoat());

		public MoveMagicCoat() : base(
			"Magic-Coat",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 4 // Acc & Priority
		) {}
	}
}