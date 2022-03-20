using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the Defense of all grass Pokémon in battle.
	public class MoveFlowerShield : Move
	{
#nullable enable
		private static MoveFlowerShield? _instance = null;
#nullable restore
        public static MoveFlowerShield Instance => _instance ?? (_instance = new MoveFlowerShield());

		public MoveFlowerShield() : base(
			"Flower-Shield",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}