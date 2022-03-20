using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Speed by one stage.
	public class MoveLowSweep : Move
	{
#nullable enable
		private static MoveLowSweep? _instance = null;
#nullable restore
        public static MoveLowSweep Instance => _instance ?? (_instance = new MoveLowSweep());

		public MoveLowSweep() : base(
			"Low-Sweep",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 65,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}