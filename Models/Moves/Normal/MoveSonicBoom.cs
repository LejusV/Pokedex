using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts 20 points of damage.
	public class MoveSonicBoom : Move
	{
#nullable enable
		private static MoveSonicBoom? _instance = null;
#nullable restore
        public static MoveSonicBoom Instance => _instance ?? (_instance = new MoveSonicBoom());

		public MoveSonicBoom() : base(
			"Sonic-Boom",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, null,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}