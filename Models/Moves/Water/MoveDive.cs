using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User dives underwater, dodging all attacks, and hits next turn.
	public class MoveDive : Move
	{
#nullable enable
		private static MoveDive? _instance = null;
#nullable restore
        public static MoveDive Instance => _instance ?? (_instance = new MoveDive());

		public MoveDive() : base(
			"Dive",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}