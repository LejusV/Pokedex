using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the target from leaving battle.
	public class MoveSpiderWeb : Move
	{
#nullable enable
		private static MoveSpiderWeb? _instance = null;
#nullable restore
        public static MoveSpiderWeb Instance => _instance ?? (_instance = new MoveSpiderWeb());

		public MoveSpiderWeb() : base(
			"Spider-Web",
			Bug.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}