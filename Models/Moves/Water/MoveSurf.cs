using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage and can hit Dive users.
	public class MoveSurf : Move
	{
#nullable enable
		private static MoveSurf? _instance = null;
#nullable restore
        public static MoveSurf Instance => _instance ?? (_instance = new MoveSurf());

		public MoveSurf() : base(
			"Surf",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}