using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Drains half the damage inflicted to heal the user.
	public class MoveMegaDrain : Move
	{
#nullable enable
		private static MoveMegaDrain? _instance = null;
#nullable restore
        public static MoveMegaDrain Instance => _instance ?? (_instance = new MoveMegaDrain());

		public MoveMegaDrain() : base(
			"Mega-Drain",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}