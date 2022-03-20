using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Removes the user's fire type after inflicting damage.
	public class MoveBurnUp : Move
	{
#nullable enable
		private static MoveBurnUp? _instance = null;
#nullable restore
        public static MoveBurnUp Instance => _instance ?? (_instance = new MoveBurnUp());

		public MoveBurnUp() : base(
			"Burn-Up",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 130,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}