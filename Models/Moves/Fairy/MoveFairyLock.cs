using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents all Pokémon from fleeing or switching out during the next turn.
	public class MoveFairyLock : Move
	{
#nullable enable
		private static MoveFairyLock? _instance = null;
#nullable restore
        public static MoveFairyLock Instance => _instance ?? (_instance = new MoveFairyLock());

		public MoveFairyLock() : base(
			"Fairy-Lock",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}