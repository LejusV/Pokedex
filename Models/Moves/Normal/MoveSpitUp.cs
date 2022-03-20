using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power is 100 times the amount of energy Stockpiled.
	public class MoveSpitUp : Move
	{
#nullable enable
		private static MoveSpitUp? _instance = null;
#nullable restore
        public static MoveSpitUp Instance => _instance ?? (_instance = new MoveSpitUp());

		public MoveSpitUp() : base(
			"Spit-Up",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}