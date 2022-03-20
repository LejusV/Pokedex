using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveDualWingbeat : Move
	{
#nullable enable
		private static MoveDualWingbeat? _instance = null;
#nullable restore
        public static MoveDualWingbeat Instance => _instance ?? (_instance = new MoveDualWingbeat());

		public MoveDualWingbeat() : base(
			"Dual-Wingbeat",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 40,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}