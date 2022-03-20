using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveDragonClaw : Move
	{
#nullable enable
		private static MoveDragonClaw? _instance = null;
#nullable restore
        public static MoveDragonClaw Instance => _instance ?? (_instance = new MoveDragonClaw());

		public MoveDragonClaw() : base(
			"Dragon-Claw",
			Dragon.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}