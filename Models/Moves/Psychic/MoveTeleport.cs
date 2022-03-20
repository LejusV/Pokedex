using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Immediately ends wild battles.  No effect otherwise.
	public class MoveTeleport : Move
	{
#nullable enable
		private static MoveTeleport? _instance = null;
#nullable restore
        public static MoveTeleport Instance => _instance ?? (_instance = new MoveTeleport());

		public MoveTeleport() : base(
			"Teleport",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, -6 // Acc & Priority
		) {}
	}
}