using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Nullifies the target's ability if it moves earlier.
	public class MoveCoreEnforcer : Move
	{
#nullable enable
		private static MoveCoreEnforcer? _instance = null;
#nullable restore
        public static MoveCoreEnforcer Instance => _instance ?? (_instance = new MoveCoreEnforcer());

		public MoveCoreEnforcer() : base(
			"Core-Enforcer",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}