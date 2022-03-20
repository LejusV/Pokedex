using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBaddyBad : Move
	{
#nullable enable
		private static MoveBaddyBad? _instance = null;
#nullable restore
        public static MoveBaddyBad Instance => _instance ?? (_instance = new MoveBaddyBad());

		public MoveBaddyBad() : base(
			"Baddy-Bad",
			Dark.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 80,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}