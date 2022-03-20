using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Permanently becomes the target's last used move.
	public class MoveSketch : Move
	{
#nullable enable
		private static MoveSketch? _instance = null;
#nullable restore
        public static MoveSketch Instance => _instance ?? (_instance = new MoveSketch());

		public MoveSketch() : base(
			"Sketch",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}