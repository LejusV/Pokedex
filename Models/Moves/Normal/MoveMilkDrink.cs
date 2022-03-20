using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Heals the user by half its max HP.
	public class MoveMilkDrink : Move
	{
#nullable enable
		private static MoveMilkDrink? _instance = null;
#nullable restore
        public static MoveMilkDrink Instance => _instance ?? (_instance = new MoveMilkDrink());

		public MoveMilkDrink() : base(
			"Milk-Drink",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}