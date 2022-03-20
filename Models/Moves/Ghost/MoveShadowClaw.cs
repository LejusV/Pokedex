using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveShadowClaw : Move
	{
#nullable enable
		private static MoveShadowClaw? _instance = null;
#nullable restore
        public static MoveShadowClaw Instance => _instance ?? (_instance = new MoveShadowClaw());

		public MoveShadowClaw() : base(
			"Shadow-Claw",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}