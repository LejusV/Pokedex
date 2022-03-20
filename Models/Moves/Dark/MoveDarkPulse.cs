using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to make the target flinch.
	public class MoveDarkPulse : Move
	{
#nullable enable
		private static MoveDarkPulse? _instance = null;
#nullable restore
        public static MoveDarkPulse Instance => _instance ?? (_instance = new MoveDarkPulse());

		public MoveDarkPulse() : base(
			"Dark-Pulse",
			Dark.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}