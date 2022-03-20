using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Attack, Special Attack, and Speed by one stage if it is poisoned.
	public class MoveVenomDrench : Move
	{
#nullable enable
		private static MoveVenomDrench? _instance = null;
#nullable restore
        public static MoveVenomDrench Instance => _instance ?? (_instance = new MoveVenomDrench());

		public MoveVenomDrench() : base(
			"Venom-Drench",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}