using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to lower the target's Special Defense by one stage.
	public class MoveShadowBall : Move
	{
#nullable enable
		private static MoveShadowBall? _instance = null;
#nullable restore
        public static MoveShadowBall Instance => _instance ?? (_instance = new MoveShadowBall());

		public MoveShadowBall() : base(
			"Shadow-Ball",
			Ghost.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}