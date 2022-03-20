using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power increases with happiness, up to a maximum of 102.
	public class MoveReturn : Move
	{
#nullable enable
		private static MoveReturn? _instance = null;
#nullable restore
        public static MoveReturn Instance => _instance ?? (_instance = new MoveReturn());

		public MoveReturn() : base(
			"Return",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}