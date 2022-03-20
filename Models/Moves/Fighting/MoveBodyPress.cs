using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveBodyPress : Move
	{
#nullable enable
		private static MoveBodyPress? _instance = null;
#nullable restore
        public static MoveBodyPress Instance => _instance ?? (_instance = new MoveBodyPress());

		public MoveBodyPress() : base(
			"Body-Press",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}