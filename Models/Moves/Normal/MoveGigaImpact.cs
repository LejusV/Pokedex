using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User foregoes its next turn to recharge.
	public class MoveGigaImpact : Move
	{
#nullable enable
		private static MoveGigaImpact? _instance = null;
#nullable restore
        public static MoveGigaImpact Instance => _instance ?? (_instance = new MoveGigaImpact());

		public MoveGigaImpact() : base(
			"Giga-Impact",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 150,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}