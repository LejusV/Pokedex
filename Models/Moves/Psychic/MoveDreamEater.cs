using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Only works on sleeping Pokémon.  Drains half the damage inflicted to heal the user.
	public class MoveDreamEater : Move
	{
#nullable enable
		private static MoveDreamEater? _instance = null;
#nullable restore
        public static MoveDreamEater Instance => _instance ?? (_instance = new MoveDreamEater());

		public MoveDreamEater() : base(
			"Dream-Eater",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}