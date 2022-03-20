using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Blocks damaging attacks and damages attacking Pokémon for 1/8 their max HP.
	public class MoveSpikyShield : Move
	{
#nullable enable
		private static MoveSpikyShield? _instance = null;
#nullable restore
        public static MoveSpikyShield Instance => _instance ?? (_instance = new MoveSpikyShield());

		public MoveSpikyShield() : base(
			"Spiky-Shield",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 4 // Acc & Priority
		) {}
	}
}