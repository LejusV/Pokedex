using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//For five turns, slower Pokémon will act before faster Pokémon.
	public class MoveTrickRoom : Move
	{
#nullable enable
		private static MoveTrickRoom? _instance = null;
#nullable restore
        public static MoveTrickRoom Instance => _instance ?? (_instance = new MoveTrickRoom());

		public MoveTrickRoom() : base(
			"Trick-Room",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, -7 // Acc & Priority
		) {}
	}
}