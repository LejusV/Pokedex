using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has double power if it's used more than once per turn.
	public class MoveRound : Move
	{
#nullable enable
		private static MoveRound? _instance = null;
#nullable restore
        public static MoveRound Instance => _instance ?? (_instance = new MoveRound());

		public MoveRound() : base(
			"Round",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}