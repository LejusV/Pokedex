using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MoveLeafBlade : Move
	{
#nullable enable
		private static MoveLeafBlade? _instance = null;
#nullable restore
        public static MoveLeafBlade Instance => _instance ?? (_instance = new MoveLeafBlade());

		public MoveLeafBlade() : base(
			"Leaf-Blade",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}