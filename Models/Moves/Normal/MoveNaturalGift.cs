using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power and type depend on the held berry.
	public class MoveNaturalGift : Move
	{
#nullable enable
		private static MoveNaturalGift? _instance = null;
#nullable restore
        public static MoveNaturalGift Instance => _instance ?? (_instance = new MoveNaturalGift());

		public MoveNaturalGift() : base(
			"Natural-Gift",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}