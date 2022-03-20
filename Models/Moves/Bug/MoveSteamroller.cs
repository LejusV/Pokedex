using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveSteamroller : Move
	{
#nullable enable
		private static MoveSteamroller? _instance = null;
#nullable restore
        public static MoveSteamroller Instance => _instance ?? (_instance = new MoveSteamroller());

		public MoveSteamroller() : base(
			"Steamroller",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 65,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}