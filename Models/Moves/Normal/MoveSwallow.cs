using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Recovers 1/4 HP after one Stockpile, 1/2 HP after two Stockpiles, or full HP after three Stockpiles.
	public class MoveSwallow : Move
	{
#nullable enable
		private static MoveSwallow? _instance = null;
#nullable restore
        public static MoveSwallow Instance => _instance ?? (_instance = new MoveSwallow());

		public MoveSwallow() : base(
			"Swallow",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}