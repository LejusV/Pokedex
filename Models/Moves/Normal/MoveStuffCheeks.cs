using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Cures the entire party of major status effects after inflicting damage.
	public class MoveStuffCheeks : Move
	{
#nullable enable
		private static MoveStuffCheeks? _instance = null;
#nullable restore
        public static MoveStuffCheeks Instance => _instance ?? (_instance = new MoveStuffCheeks());

		public MoveStuffCheeks() : base(
			"Stuff-Cheeks",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}