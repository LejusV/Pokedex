using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 50% chance to lower the target's Special Attack by one stage.
	public class MoveMistBall : Move
	{
#nullable enable
		private static MoveMistBall? _instance = null;
#nullable restore
        public static MoveMistBall Instance => _instance ?? (_instance = new MoveMistBall());

		public MoveMistBall() : base(
			"Mist-Ball",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}