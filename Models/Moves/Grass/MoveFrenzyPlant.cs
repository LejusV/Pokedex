using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User foregoes its next turn to recharge.
	public class MoveFrenzyPlant : Move
	{
#nullable enable
		private static MoveFrenzyPlant? _instance = null;
#nullable restore
        public static MoveFrenzyPlant Instance => _instance ?? (_instance = new MoveFrenzyPlant());

		public MoveFrenzyPlant() : base(
			"Frenzy-Plant",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 150,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}