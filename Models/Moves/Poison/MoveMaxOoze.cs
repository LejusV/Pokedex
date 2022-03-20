using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxOoze : Move
	{
#nullable enable
		private static MoveMaxOoze? _instance = null;
#nullable restore
        public static MoveMaxOoze Instance => _instance ?? (_instance = new MoveMaxOoze());

		public MoveMaxOoze() : base(
			"Max-Ooze",
			Poison.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}