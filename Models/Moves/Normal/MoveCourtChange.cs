using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveCourtChange : Move
	{
#nullable enable
		private static MoveCourtChange? _instance = null;
#nullable restore
        public static MoveCourtChange Instance => _instance ?? (_instance = new MoveCourtChange());

		public MoveCourtChange() : base(
			"Court-Change",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}