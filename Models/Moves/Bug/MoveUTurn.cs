using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User must switch out after attacking.
	public class MoveUTurn : Move
	{
#nullable enable
		private static MoveUTurn? _instance = null;
#nullable restore
        public static MoveUTurn Instance => _instance ?? (_instance = new MoveUTurn());

		public MoveUTurn() : base(
			"U-Turn",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}