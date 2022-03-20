using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaxAirstream : Move
	{
#nullable enable
		private static MoveMaxAirstream? _instance = null;
#nullable restore
        public static MoveMaxAirstream Instance => _instance ?? (_instance = new MoveMaxAirstream());

		public MoveMaxAirstream() : base(
			"Max-Airstream",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 10,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}