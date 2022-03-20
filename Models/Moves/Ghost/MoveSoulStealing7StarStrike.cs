using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSoulStealing7StarStrike : Move
	{
#nullable enable
		private static MoveSoulStealing7StarStrike? _instance = null;
#nullable restore
        public static MoveSoulStealing7StarStrike Instance => _instance ?? (_instance = new MoveSoulStealing7StarStrike());

		public MoveSoulStealing7StarStrike() : base(
			"Soul-Stealing-7-Star-Strike",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, 195,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}