using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power increases against targets with more HP remaining, up to a maximum of 121 power.
	public class MoveWringOut : Move
	{
#nullable enable
		private static MoveWringOut? _instance = null;
#nullable restore
        public static MoveWringOut Instance => _instance ?? (_instance = new MoveWringOut());

		public MoveWringOut() : base(
			"Wring-Out",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}