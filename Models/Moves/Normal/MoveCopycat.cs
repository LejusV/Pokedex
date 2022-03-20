using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Uses the target's last used move.
	public class MoveCopycat : Move
	{
#nullable enable
		private static MoveCopycat? _instance = null;
#nullable restore
        public static MoveCopycat Instance => _instance ?? (_instance = new MoveCopycat());

		public MoveCopycat() : base(
			"Copycat",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}