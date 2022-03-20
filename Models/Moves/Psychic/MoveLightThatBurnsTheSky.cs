using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts damage using either Attack or Special Attack stat, whichever is higher.
	public class MoveLightThatBurnsTheSky : Move
	{
#nullable enable
		private static MoveLightThatBurnsTheSky? _instance = null;
#nullable restore
        public static MoveLightThatBurnsTheSky Instance => _instance ?? (_instance = new MoveLightThatBurnsTheSky());

		public MoveLightThatBurnsTheSky() : base(
			"Light-That-Burns-The-Sky",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, 200,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}