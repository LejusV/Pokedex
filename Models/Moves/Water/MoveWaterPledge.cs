using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//With Grass Pledge, halves opposing Pokémon's Speed for four turns.
	public class MoveWaterPledge : Move
	{
#nullable enable
		private static MoveWaterPledge? _instance = null;
#nullable restore
        public static MoveWaterPledge Instance => _instance ?? (_instance = new MoveWaterPledge());

		public MoveWaterPledge() : base(
			"Water-Pledge",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}