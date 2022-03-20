using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Protects all friendly Pokémon from non-damaging moves.
	public class MoveCraftyShield : Move
	{
#nullable enable
		private static MoveCraftyShield? _instance = null;
#nullable restore
        public static MoveCraftyShield Instance => _instance ?? (_instance = new MoveCraftyShield());

		public MoveCraftyShield() : base(
			"Crafty-Shield",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 3 // Acc & Priority
		) {}
	}
}