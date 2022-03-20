using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Can only be used after the user has eaten a berry.
	public class MoveBelch : Move
	{
#nullable enable
		private static MoveBelch? _instance = null;
#nullable restore
        public static MoveBelch Instance => _instance ?? (_instance = new MoveBelch());

		public MoveBelch() : base(
			"Belch",
			Poison.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 120,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}