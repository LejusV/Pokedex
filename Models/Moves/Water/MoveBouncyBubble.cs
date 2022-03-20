using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBouncyBubble : Move
	{
#nullable enable
		private static MoveBouncyBubble? _instance = null;
#nullable restore
        public static MoveBouncyBubble Instance => _instance ?? (_instance = new MoveBouncyBubble());

		public MoveBouncyBubble() : base(
			"Bouncy-Bubble",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}