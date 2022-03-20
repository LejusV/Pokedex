using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//If target has a berry, inflicts double damage and uses the berry.
	public class MovePluck : Move
	{
#nullable enable
		private static MovePluck? _instance = null;
#nullable restore
        public static MovePluck Instance => _instance ?? (_instance = new MovePluck());

		public MovePluck() : base(
			"Pluck",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}