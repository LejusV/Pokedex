using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has double power if the user has no held item.
	public class MoveAcrobatics : Move
	{
#nullable enable
		private static MoveAcrobatics? _instance = null;
#nullable restore
        public static MoveAcrobatics Instance => _instance ?? (_instance = new MoveAcrobatics());

		public MoveAcrobatics() : base(
			"Acrobatics",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 55,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}