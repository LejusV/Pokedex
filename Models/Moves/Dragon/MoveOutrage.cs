using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits every turn for 2-3 turns, then confuses the user.
	public class MoveOutrage : Move
	{
#nullable enable
		private static MoveOutrage? _instance = null;
#nullable restore
        public static MoveOutrage Instance => _instance ?? (_instance = new MoveOutrage());

		public MoveOutrage() : base(
			"Outrage",
			Dragon.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}