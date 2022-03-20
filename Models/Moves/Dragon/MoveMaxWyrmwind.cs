using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxWyrmwind : Move
	{
#nullable enable
		private static MoveMaxWyrmwind? _instance = null;
#nullable restore
        public static MoveMaxWyrmwind Instance => _instance ?? (_instance = new MoveMaxWyrmwind());

		public MoveMaxWyrmwind() : base(
			"Max-Wyrmwind",
			Dragon.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}