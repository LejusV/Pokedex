using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Attack by one stage.
	public class MoveGrowl : Move
	{
#nullable enable
		private static MoveGrowl? _instance = null;
#nullable restore
        public static MoveGrowl Instance => _instance ?? (_instance = new MoveGrowl());

		public MoveGrowl() : base(
			"Growl",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}