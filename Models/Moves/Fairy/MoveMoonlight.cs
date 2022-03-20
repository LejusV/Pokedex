using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Heals the user by half its max HP.  Affected by weather.
	public class MoveMoonlight : Move
	{
#nullable enable
		private static MoveMoonlight? _instance = null;
#nullable restore
        public static MoveMoonlight Instance => _instance ?? (_instance = new MoveMoonlight());

		public MoveMoonlight() : base(
			"Moonlight",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}