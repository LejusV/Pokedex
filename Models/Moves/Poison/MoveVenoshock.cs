using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts double damage if the target is Poisoned.
	public class MoveVenoshock : Move
	{
#nullable enable
		private static MoveVenoshock? _instance = null;
#nullable restore
        public static MoveVenoshock Instance => _instance ?? (_instance = new MoveVenoshock());

		public MoveVenoshock() : base(
			"Venoshock",
			Poison.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 65,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}