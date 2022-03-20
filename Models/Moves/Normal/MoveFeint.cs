using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits through Protect and Detect.
	public class MoveFeint : Move
	{
#nullable enable
		private static MoveFeint? _instance = null;
#nullable restore
        public static MoveFeint Instance => _instance ?? (_instance = new MoveFeint());

		public MoveFeint() : base(
			"Feint",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 30,// PP & Pow
			100, 2 // Acc & Priority
		) {}
	}
}