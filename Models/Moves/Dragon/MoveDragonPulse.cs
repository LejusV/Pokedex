using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveDragonPulse : Move
	{
#nullable enable
		private static MoveDragonPulse? _instance = null;
#nullable restore
        public static MoveDragonPulse Instance => _instance ?? (_instance = new MoveDragonPulse());

		public MoveDragonPulse() : base(
			"Dragon-Pulse",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 85,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}