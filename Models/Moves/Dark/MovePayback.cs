using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power is doubled if the target has already moved this turn.
	public class MovePayback : Move
	{
#nullable enable
		private static MovePayback? _instance = null;
#nullable restore
        public static MovePayback Instance => _instance ?? (_instance = new MovePayback());

		public MovePayback() : base(
			"Payback",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}