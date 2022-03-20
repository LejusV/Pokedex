using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Does nothing.
	public class MoveCelebrate : Move
	{
#nullable enable
		private static MoveCelebrate? _instance = null;
#nullable restore
        public static MoveCelebrate Instance => _instance ?? (_instance = new MoveCelebrate());

		public MoveCelebrate() : base(
			"Celebrate",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}