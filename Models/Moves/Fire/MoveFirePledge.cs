using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//With Water Pledge, doubles the effect chance of friendly Pokémon's moves for four turns.
	public class MoveFirePledge : Move
	{
#nullable enable
		private static MoveFirePledge? _instance = null;
#nullable restore
        public static MoveFirePledge Instance => _instance ?? (_instance = new MoveFirePledge());

		public MoveFirePledge() : base(
			"Fire-Pledge",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}