using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveTarShot : Move
	{
#nullable enable
		private static MoveTarShot? _instance = null;
#nullable restore
        public static MoveTarShot Instance => _instance ?? (_instance = new MoveTarShot());

		public MoveTarShot() : base(
			"Tar-Shot",
			Rock.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}