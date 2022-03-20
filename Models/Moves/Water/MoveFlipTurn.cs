using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveFlipTurn : Move
	{
#nullable enable
		private static MoveFlipTurn? _instance = null;
#nullable restore
        public static MoveFlipTurn Instance => _instance ?? (_instance = new MoveFlipTurn());

		public MoveFlipTurn() : base(
			"Flip-Turn",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}