using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User receives 1/3 the damage inflicted in recoil.
	public class MoveDoubleEdge : Move
	{
#nullable enable
		private static MoveDoubleEdge? _instance = null;
#nullable restore
        public static MoveDoubleEdge Instance => _instance ?? (_instance = new MoveDoubleEdge());

		public MoveDoubleEdge() : base(
			"Double-Edge",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}