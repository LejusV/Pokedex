using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Attack and Special Attack by one stage.
	public class MoveGrowth : Move
	{
#nullable enable
		private static MoveGrowth? _instance = null;
#nullable restore
        public static MoveGrowth Instance => _instance ?? (_instance = new MoveGrowth());

		public MoveGrowth() : base(
			"Growth",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}