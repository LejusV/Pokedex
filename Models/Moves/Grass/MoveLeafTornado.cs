using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 50% chance to lower the target's accuracy by one stage.
	public class MoveLeafTornado : Move
	{
#nullable enable
		private static MoveLeafTornado? _instance = null;
#nullable restore
        public static MoveLeafTornado Instance => _instance ?? (_instance = new MoveLeafTornado());

		public MoveLeafTornado() : base(
			"Leaf-Tornado",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 65,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}