using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to raise the user's Attack by one stage.
	public class MoveMetalClaw : Move
	{
#nullable enable
		private static MoveMetalClaw? _instance = null;
#nullable restore
        public static MoveMetalClaw Instance => _instance ?? (_instance = new MoveMetalClaw());

		public MoveMetalClaw() : base(
			"Metal-Claw",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			35, 50,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}