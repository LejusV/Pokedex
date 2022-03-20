using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Requires a turn to charge before attacking.
	public class MoveSolarBlade : Move
	{
#nullable enable
		private static MoveSolarBlade? _instance = null;
#nullable restore
        public static MoveSolarBlade Instance => _instance ?? (_instance = new MoveSolarBlade());

		public MoveSolarBlade() : base(
			"Solar-Blade",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 125,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}