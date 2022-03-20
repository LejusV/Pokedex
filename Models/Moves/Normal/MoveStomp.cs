using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveStomp : Move
	{
#nullable enable
		private static MoveStomp? _instance = null;
#nullable restore
        public static MoveStomp Instance => _instance ?? (_instance = new MoveStomp());

		public MoveStomp() : base(
			"Stomp",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 65,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}