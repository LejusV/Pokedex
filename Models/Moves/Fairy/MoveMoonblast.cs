using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to lower the target's Special Attack by one stage.
	public class MoveMoonblast : Move
	{
#nullable enable
		private static MoveMoonblast? _instance = null;
#nullable restore
        public static MoveMoonblast Instance => _instance ?? (_instance = new MoveMoonblast());

		public MoveMoonblast() : base(
			"Moonblast",
			Fairy.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 95,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}