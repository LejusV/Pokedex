using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's accuracy by one stage.
	public class MoveFlash : Move
	{
#nullable enable
		private static MoveFlash? _instance = null;
#nullable restore
        public static MoveFlash Instance => _instance ?? (_instance = new MoveFlash());

		public MoveFlash() : base(
			"Flash",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}