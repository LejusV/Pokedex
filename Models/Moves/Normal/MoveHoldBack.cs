using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Cannot lower the target's HP below 1.
	public class MoveHoldBack : Move
	{
#nullable enable
		private static MoveHoldBack? _instance = null;
#nullable restore
        public static MoveHoldBack Instance => _instance ?? (_instance = new MoveHoldBack());

		public MoveHoldBack() : base(
			"Hold-Back",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			40, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}