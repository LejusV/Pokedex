using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveTeatime : Move
	{
#nullable enable
		private static MoveTeatime? _instance = null;
#nullable restore
        public static MoveTeatime Instance => _instance ?? (_instance = new MoveTeatime());

		public MoveTeatime() : base(
			"Teatime",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}