using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Immediately ends wild battles.  Forces trainers to switch Pokémon.
	public class MoveWhirlwind : Move
	{
#nullable enable
		private static MoveWhirlwind? _instance = null;
#nullable restore
        public static MoveWhirlwind Instance => _instance ?? (_instance = new MoveWhirlwind());

		public MoveWhirlwind() : base(
			"Whirlwind",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, -6 // Acc & Priority
		) {}
	}
}