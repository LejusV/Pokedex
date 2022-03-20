using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Always scores a critical hit.
	public class MoveFrostBreath : Move
	{
#nullable enable
		private static MoveFrostBreath? _instance = null;
#nullable restore
        public static MoveFrostBreath Instance => _instance ?? (_instance = new MoveFrostBreath());

		public MoveFrostBreath() : base(
			"Frost-Breath",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 60,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}