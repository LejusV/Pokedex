using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User receives 1/3 the damage inflicted in recoil.
	public class MoveBraveBird : Move
	{
#nullable enable
		private static MoveBraveBird? _instance = null;
#nullable restore
        public static MoveBraveBird Instance => _instance ?? (_instance = new MoveBraveBird());

		public MoveBraveBird() : base(
			"Brave-Bird",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}