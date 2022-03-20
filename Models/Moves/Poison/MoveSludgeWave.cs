using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to poison the target.
	public class MoveSludgeWave : Move
	{
#nullable enable
		private static MoveSludgeWave? _instance = null;
#nullable restore
        public static MoveSludgeWave Instance => _instance ?? (_instance = new MoveSludgeWave());

		public MoveSludgeWave() : base(
			"Sludge-Wave",
			Poison.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 95,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}