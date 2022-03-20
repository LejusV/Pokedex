using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//If the user is hit after using this move, its Attack rises by one stage.
	public class MoveRage : Move
	{
#nullable enable
		private static MoveRage? _instance = null;
#nullable restore
        public static MoveRage Instance => _instance ?? (_instance = new MoveRage());

		public MoveRage() : base(
			"Rage",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 20,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}