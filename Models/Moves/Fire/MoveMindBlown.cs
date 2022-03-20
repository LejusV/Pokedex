using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts damage, and the user takes damage equal to half of its max HP, rounded up.
	public class MoveMindBlown : Move
	{
#nullable enable
		private static MoveMindBlown? _instance = null;
#nullable restore
        public static MoveMindBlown Instance => _instance ?? (_instance = new MoveMindBlown());

		public MoveMindBlown() : base(
			"Mind-Blown",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 150,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}