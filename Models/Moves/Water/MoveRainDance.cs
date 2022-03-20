using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Changes the weather to rain for five turns.
	public class MoveRainDance : Move
	{
#nullable enable
		private static MoveRainDance? _instance = null;
#nullable restore
        public static MoveRainDance Instance => _instance ?? (_instance = new MoveRainDance());

		public MoveRainDance() : base(
			"Rain-Dance",
			Water.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}