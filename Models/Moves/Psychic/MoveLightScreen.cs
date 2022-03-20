using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Reduces damage from special attacks by 50% for five turns.
	public class MoveLightScreen : Move
	{
#nullable enable
		private static MoveLightScreen? _instance = null;
#nullable restore
        public static MoveLightScreen Instance => _instance ?? (_instance = new MoveLightScreen());

		public MoveLightScreen() : base(
			"Light-Screen",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}