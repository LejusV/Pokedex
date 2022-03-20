using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Changes the target's ability to Insomnia.
	public class MoveWorrySeed : Move
	{
#nullable enable
		private static MoveWorrySeed? _instance = null;
#nullable restore
        public static MoveWorrySeed Instance => _instance ?? (_instance = new MoveWorrySeed());

		public MoveWorrySeed() : base(
			"Worry-Seed",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}