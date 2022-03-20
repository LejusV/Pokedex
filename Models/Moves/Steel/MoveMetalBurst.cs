using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Strikes back at the last Pokémon to hit the user this turn with 1.5× the damage.
	public class MoveMetalBurst : Move
	{
#nullable enable
		private static MoveMetalBurst? _instance = null;
#nullable restore
        public static MoveMetalBurst Instance => _instance ?? (_instance = new MoveMetalBurst());

		public MoveMetalBurst() : base(
			"Metal-Burst",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}