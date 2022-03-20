using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Heals the user by the target's current Attack stat and lowers the target's Attack by one stage.
	public class MoveStrengthSap : Move
	{
#nullable enable
		private static MoveStrengthSap? _instance = null;
#nullable restore
        public static MoveStrengthSap Instance => _instance ?? (_instance = new MoveStrengthSap());

		public MoveStrengthSap() : base(
			"Strength-Sap",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}