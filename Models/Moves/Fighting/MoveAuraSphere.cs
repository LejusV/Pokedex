using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveAuraSphere : Move
	{
#nullable enable
		private static MoveAuraSphere? _instance = null;
#nullable restore
        public static MoveAuraSphere Instance => _instance ?? (_instance = new MoveAuraSphere());

		public MoveAuraSphere() : base(
			"Aura-Sphere",
			Fighting.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 80,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}