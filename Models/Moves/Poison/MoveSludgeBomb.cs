using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to poison the target.
	public class MoveSludgeBomb : Move
	{
#nullable enable
		private static MoveSludgeBomb? _instance = null;
#nullable restore
        public static MoveSludgeBomb Instance => _instance ?? (_instance = new MoveSludgeBomb());

		public MoveSludgeBomb() : base(
			"Sludge-Bomb",
			Poison.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}