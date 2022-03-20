using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//With Fire Pledge, damages opposing Pokémon for 1/8 their max HP every turn for four turns.
	public class MoveGrassPledge : Move
	{
#nullable enable
		private static MoveGrassPledge? _instance = null;
#nullable restore
        public static MoveGrassPledge Instance => _instance ?? (_instance = new MoveGrassPledge());

		public MoveGrassPledge() : base(
			"Grass-Pledge",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}